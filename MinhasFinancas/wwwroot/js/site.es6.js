(function ($, window, document, undefined) {
    window.minhasFinancas = {
        confirm: function (message) {
            const deferred = $.Deferred();
            const overlayClass = 'overlay';

            document.body.classList.add(overlayClass);

            setTimeout(() => {
                if (confirm(message)) {
                    deferred.resolve();
                } else {
                    deferred.reject();
                }

                document.body.classList.remove(overlayClass);
            }, 30);

            return deferred;
        },
        postJson: function (url, data) {
            return $.ajax({
                url: url,
                //data: JSON.stringify(data),
                data: data,
                type: 'POST',
                contentType: 'application/json charset=utf-8',
                dataType: 'json'
            });
        },
        getJson: function (url, data) {
            return $.ajax({
                url: url,
                data: data,
                type: 'GET',
                dataType: 'json'
            });
        },
    };
})(jQuery, window, document);;