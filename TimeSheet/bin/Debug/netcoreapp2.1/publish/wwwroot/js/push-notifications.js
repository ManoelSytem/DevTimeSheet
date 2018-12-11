var applicationServerPublicKey = 'BJiYyb7ylU_iaOohTta5xR2QHuEDddwIzeUWUyGzGoiJOpaMsxBVt7tIU8zAkmmY_NANOFVoY6-Z6JA72gRJQQ0';
var serviceWorker = '/sw.js';
var isSubscribed = false;

$(document).ready(function () {
    if (typeof applicationServerPublicKey === 'undefined') {
        errorHandler('Vapid public key is undefined.');
        return;
    }

    Notification.requestPermission().then(function (status) {
        if (status === 'denied') {
            errorHandler('[Notification.requestPermission] Browser denied permissions to notification api.');
        } else if (status === 'granted') {
            console.log('[Notification.requestPermission] Initializing service worker.');
            initialiseServiceWorker();
        }
    });

    subscribe();
});

function initialiseServiceWorker() {
    if ('serviceWorker' in navigator) {
        navigator.serviceWorker.register(serviceWorker).then(handleSWRegistration);
    } else {
        errorHandler('[initialiseServiceWorker] Service workers are not supported in this browser.');
    }
}

function handleSWRegistration(reg) {
    if (reg.installing) {
        console.log('Service worker installing');
    } else if (reg.waiting) {
        console.log('Service worker installed');
    } else if (reg.active) {
        console.log('Service worker active');
    }

    initialiseState(reg);
}

function initialiseState(reg) {
    if (!reg.showNotification) {
        errorHandler('[initialiseState] Notifications aren\'t supported on service workers.');
        return;
    }

    if (!('PushManager' in window)) {
        errorHandler('[initialiseState] Push messaging isn\'t supported.');
        return;
    }
    navigator.serviceWorker.ready.then(function (reg) {
        reg.pushManager.getSubscription()
            .then(function (subscription) {
                isSubscribed = subscription;
                if (isSubscribed) {
                    console.log('User is already subscribed to push notifications');
                } else {
                    console.log('User is not yet subscribed to push notifications');
                }
            })
            .catch(function (err) {
                console.log('[req.pushManager.getSubscription] Unable to get subscription details.', err);
            });
    });
}

function subscribe() {
    navigator.serviceWorker.ready.then(function (reg) {
        var subscribeParams = { userVisibleOnly: true };
        var applicationServerKey = urlB64ToUint8Array(applicationServerPublicKey);
        subscribeParams.applicationServerKey = applicationServerKey;

        reg.pushManager.subscribe(subscribeParams).then(function (subscription) {
            isSubscribed = true;
            var p256dh = base64Encode(subscription.getKey('p256dh'));
            var auth = base64Encode(subscription.getKey('auth'));

            $.ajax({
                url: "/Dispositivo/CreateSubscription",
                data: {
                    PushEndpoint: subscription.endpoint,
                    PushP256DH: p256dh,
                    PushAuth: auth
                },
                type: 'post'
            }).done(function (data) {
            });
            console.log(subscription);
        }).catch(function (e) {
            errorHandler('[subscribe] Unable to subscribe to push', e);
        });
    });
}

function errorHandler(message, e) {
    if (typeof e == 'undefined') {
        e = null;
    }
    console.error(message, e);
}

function urlB64ToUint8Array(base64String) {
    var padding = '='.repeat((4 - base64String.length % 4) % 4);
    var base64 = (base64String + padding)
        .replace(/\-/g, '+')
        .replace(/_/g, '/');

    var rawData = window.atob(base64);
    var outputArray = new Uint8Array(rawData.length);

    for (var i = 0; i < rawData.length; ++i) {
        outputArray[i] = rawData.charCodeAt(i);
    }
    return outputArray;
}

function base64Encode(arrayBuffer) {
    return btoa(String.fromCharCode.apply(null, new Uint8Array(arrayBuffer)));
}