$(document).ready(function () {

    DataTable:

    $('#tb1').DataTable({

        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "TDS"]],

        "columnDefs": [
            { className: "text-right", "targets": [] },
            { className: "text-left", "targets": [0, 1, 2, 3] },
            { "orderable": false, "targets": [4, 5] }
        ],

        "language": {

            "decimal": "",
            "emptyTable": "Nenhum registro disponível na tabela",
            "info": "Visualizando _START_ de _END_ de _TOTAL_ registros",
            "infoEmpty": "Visualizando 0 de 0 de 0 registros",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ registros",
            "loadingRecords": "Carregando...",
            "processing": "Processando...",
            "search": "Pesquisar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeira",
                "last": "Última",
                "next": "Próxima",
                "previous": "Anterior"
            }
        },

    });

    $('#tb2').DataTable({

        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "TDS"]],

        "columnDefs": [
            { "orderable": false, "targets": [4] }
        ],

        "language": {

            "decimal": "",
            "emptyTable": "Nenhum registro disponível na tabela",
            "info": "Visualizando _START_ de _END_ de _TOTAL_ registros",
            "infoEmpty": "Visualizando 0 de 0 de 0 registros",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ registros",
            "loadingRecords": "Carregando...",
            "processing": "Processando...",
            "search": "Pesquisar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeira",
                "last": "Última",
                "next": "Próxima",
                "previous": "Anterior"
            }
        },

        "footerCallback": function (row, data, start, end, display) {
            var api = this.api();

            api.columns('.sum', { page: 'current' }).every(
                function () {
                    var sum = this.data().reduce(
                        function (a, b) {
                            var x = parseFloat(a) || 0;
                            var y = parseFloat(b) || 0;
                            return x + y;
                        },
                        0
                    );

                    $(this.footer()).html(sum);
                });
        }
    });
});

$('.btn-ft-item').click(function () {
    document.getElementById("btn-ft-open").checked = false;
});


function Alerta(tipo, mensagem) {
    var classe = "";
    if (tipo === "Sucesso") classe = "success";
    if (tipo === "Erro") classe = "danger";
    if (tipo === "Informação") classe = "info";
    if (tipo === "Atenção") classe = "warning";
    
    var alert = `<div class="alert alert-${classe} alert-dismissable fade show" role="alert">
	                <i class="fas fa-check-circle fa-lg"></i>
	                <strong>${tipo}</strong>${mensagem}
	                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>`;

    setTimeout(function () {
        $(".alert").fadeOut();
    }, 7000);
    return alert;
}

function Danger(alert) {
    $("#alertas").append(Alerta("Erro", alert));
}

function Success(alert) {
    $("#alertas").append(Alerta("Sucesso", alert));
}

function Information(alert) {
    $("#alertas").append(Alerta("Informação", alert));
}

function Warning(alert) {
    $("#alertas").append(Alerta("Atenção", alert));
}

function AutoClose() {
    window.setTimeout(function () {
        $(".alert").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 5000);
}

//$(document).ready(function () {
//    $('.decimal').maskNumber();
//    $('.money').maskMoney({ thousands: '.', decimal: ',', allowZero: false, precision: 2 });
//    $('.money1').maskMoney({ thousands: '.', decimal: ',', allowZero: false, precision: 1 });
//    $('.money3').maskMoney({ thousands: '.', decimal: ',', allowZero: false, precision: 3 });
//    $('.money4').maskMoney({ thousands: '.', decimal: ',', allowZero: false, precision: 4 });
//    //$('.data').mask("99/99/9999", { placeholder: ' ', completed: false });
//});


function ToNumber(valor) {
    return Number(valor.replace('.', '').replace(',', '.'));
}