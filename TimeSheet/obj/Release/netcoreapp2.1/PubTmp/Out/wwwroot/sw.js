self.addEventListener('push', function (event) {
    if (!(self.Notification && self.Notification.permission === 'granted')) {
        return;
    }

    var data = {};
    if (event.data) {
        data = event.data.json();
    }

    console.log('Notification Recieved:');
    console.log(data);

    var title = data.title;
    var message = data.message;
    var icon = "images/logo192x192.png";

    event.waitUntil(self.registration.showNotification(title, {
        body: message,
        icon: icon,
        vibrate: [200, 100, 200, 100, 200, 100, 200],
        badge: icon,
        data: { url: data.link }
    }));
});

self.addEventListener('notificationclick', function (event) {
    event.waitUntil(
        clients.matchAll({
            type: "window"
        }).then(function (clientList) {
            for (var i = 0; i < clientList.length; i++) {
                var client = clientList[i];
                if (client.url === '/' && 'focus' in client)
                    return client.focus();
            }
            if (clients.openWindow) {
                return clients.openWindow(event.notification.data.url);
            }
        })
    );
});

self.addEventListener('fetch', function (e) {
    console.log(e.request.url);
    e.respondWith(
        caches.match(e.request).then(function (response) {
            return response || fetch(e.request);
        })
    );
});

self.addEventListener('install', function (e) {
    e.waitUntil(
        caches.open('RDO-v1').then(function (cache) {
            return cache.addAll([
                '/css/bstrap/bstrap4.css',
                '/css/bstrap/bstrap-grid.css',
                '/css/dtable/dtable.bstrap4.css',
                '/css/dtable/resp.bstrap4.css',
                '/css/system.css',
                '/js/jquery.js',
                '/js/push-notifications.js',
                '/js/system.js'
            ]);
        })
    );
});