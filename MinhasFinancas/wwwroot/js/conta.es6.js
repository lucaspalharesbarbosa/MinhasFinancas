(function ($, window) {
    var IncluirConta = function (id) {
        debugger;
        var url = "/Conta/Salvar?id=" + id;

        if (!!id) {
            $('#title').html("Editar conta");
        }

        $('#modal-form-nova-conta').load(url, function () {
            $('#modal-form-nova-conta').modal("show");
        });

        $('#modal-form-nova-conta').on('shown.bs.modal', function () {
            $('#calandar-container .input-group-date').datepicker({
                todayBtn: true,
                calendarWeeks: true,
                todayHighlight: true,
                formar: 'dd/MM/yyyy',
                autoClose: true,
                container: '#modal-form-nova-conta modal-body'
            });
        });
    }

    //window.minhasFinancas.conta = function () {
    //    var IncluirConta = function (id) {
    //        debugger;
    //        var url = "/Conta/Salvar?id=" + id;

    //        if (!!id) {
    //            $('#title').html("Editar conta");
    //        }

    //        $('#modal-form-nova-conta').load(url, function () {
    //            $('#modal-form-nova-conta').modal("show");
    //        });

    //        $('#modal-form-nova-conta').on('shown.bs.modal', function () {
    //            $('#calandar-container .input-group-date').datepicker({
    //                todayBtn: true,
    //                calendarWeeks: true,
    //                todayHighlight: true,
    //                formar: 'dd/MM/yyyy',
    //                autoClose: true,
    //                container: '#modal-form-nova-conta modal-body'
    //            });
    //        });
    //    }

    //    var AbrirContaReport = function () {

    //    }
    //}
})(jQuery, window);;