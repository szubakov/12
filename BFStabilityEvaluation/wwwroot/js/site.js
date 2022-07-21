"use strict";

$(document).ready(function () {
    $('.phone').mask('8(000) 000-00-00');
    $('.passport').mask('0000 000000');
    $('.percent').mask("##0,00", { reverse: true });
    $('.date').mask("00.00.0000");
});

// переопределение валидации на стороне клиента
$.validator.methods.range = function (value, element, param) {
    var globalizedValue = value.replace(",", ".");
    return this.optional(element) || (globalizedValue >= param[0] && globalizedValue <= param[1]);
}

$.validator.methods.number = function (value, element) {
    return this.optional(element) || /^-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
}
/*************************************************/
$(document).ready(function () {
    $('.datetimepicker').datetimepicker({
        icons: {
            time: "bi bi-clock",
            date: "bi bi-calendar",
            up: "bi bi-chevron-up",
            down: "bi bi-chevron-down",
            next: 'bi bi-chevron-right',
            previous: 'bi bi-chevron-left',
            today: 'bi bi-calendar-check-fill',
            clear: 'bi bi-trash',
            close: 'bi bi-x-circle'
        },
        locale: 'ru',
        format: 'DD.MM.YYYY HH:mm'
    });
});

$(document).ready(function () {
    $('.datepicker').datetimepicker({
        icons: {
            time: "bi bi-clock",
            date: "bi bi-calendar",
            up: "bi bi-chevron-up",
            down: "bi bi-chevron-down",
            next: 'bi bi-chevron-right',
            previous: 'bi bi-chevron-left',
            today: 'bi bi-calendar-check-fill',
            clear: 'bi bi-trash',
            close: 'bi bi-x-circle'
        },
        locale: 'ru',
        format: 'DD.MM.YYYY'
    });
});

$(document).ready(function () {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl)
    });
});

function loadFile(event, str) {
    if (event.target.files.length === 0) {
        if (event.target.id == "document") {
            document.getElementById(str).src = '../../images/no-image-min.png';
        }
        else {
            document.getElementById(str).src = '../../images/defaultUser.png';
        }
    }
    else {
        var reader = new FileReader();
        reader.onload = function () {
            var output = document.getElementById(str);
            output.src = reader.result;
        };
        reader.readAsDataURL(event.target.files[0]);
    }
}

/*Модальное*/
$(function () {
    $.ajaxSetup({ cache: false });
    $(".miniature").click(function (e) {
        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogContent').html(data);
            var myModal = new bootstrap.Modal(document.getElementById('miniatureDialog'), {
                keyboard: false
            })
            myModal.show();
        });
    });
});


/* Валидация ******************************/
(function () {
    var forms = document.querySelectorAll('.needs-validation')

    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })
})();
/***********************************/
