$(document).on('click', '.number-spinner a', function () {
    var btn = $(this),
        oldValue = btn.closest('.number-spinner').find('input').val().trim(),
        newVal = 0, minVal = 0;
    var adt = parseInt($('#Adult').val(), 10), chd = parseInt($('#Children').val(), 10), inf = parseInt($('#Infant').val(), 10);
    var nm = btn.closest('.number-spinner').find('input').attr('name').trim();
    if (nm == 'adults') { minVal = 1; }
    if (btn.attr('data-dir') == 'up') {
        newVal = parseInt(oldValue) + 1;
    }
    else {
        if (oldValue > minVal) {
            newVal = parseInt(oldValue) - 1;
        }
        else {
            newVal = minVal;
        }
    }
    if (((adt + chd + inf) >= 9 || (inf >= adt && nm == 'InfantsST')) && btn.attr('data-dir') == 'up') { }
    else if (inf == adt && btn.attr('data-dir') != 'up' && nm == 'adults') { }
    else {
        btn.closest('.number-spinner').find('input').val(newVal);
        btn.closest('.number-spinner').find('.bt_new').html(newVal);
    }
});
function first_form() {
    var a = document.getElementById("locationd").value;
    var b = document.getElementById("locationd2").value;
    document.getElementById("locationd").value = a.substring(0, 3);
    document.getElementById("locationd2").value = b.substring(0, 3);
}
jQuery(function ($) {
    $('input').focus(function () {
        $(this).removeAttr('placeholder');
    });
});
jQuery(function ($) {
    var arr = [];
    $.getJSON("/assets/js/airport.json", function (data) {
        $.each(data, function (key, value) {
            var codes = value.substring(0, 3);
            if ($.inArray(value, arr) === -1) {
                arr.push(value);
            }
        })
    });
    $("#locationd").autocomplete({
        source: function (request, response) {
            var stringLength = $.ui.autocomplete.escapeRegex(request.term).length;
            var matcher = new RegExp("^" + $.ui.autocomplete.escapeRegex(request.term), "i");
            var matcher2 = new RegExp($.ui.autocomplete.escapeRegex(request.term) + "+", "i");
            var isData = 1;
            response($.grep(arr, function (item) {
                if (stringLength <= 3) {
                    if (matcher.test(item)) {
                        isData = 22;
                    }
                    return matcher.test(item);
                }
                else {
                    if (matcher2.test(item)) {
                        isData = 22;
                    }
                    return matcher2.test(item);
                }
            }));
            if (stringLength == 3 && isData == 1) {
                response($.grep(arr, function (item) {
                    return matcher2.test(item);
                }));
            }
        },
        minLength: 1,
    });
    $("#locationd2").autocomplete({
        source: function (request, response) {
            var stringLength = $.ui.autocomplete.escapeRegex(request.term).length;
            var matcher = new RegExp("^" + $.ui.autocomplete.escapeRegex(request.term), "i");
            var matcher2 = new RegExp($.ui.autocomplete.escapeRegex(request.term) + "+", "i");
            var isData = 1;
            response($.grep(arr, function (item) {
                if (stringLength <= 3) {
                    if (matcher.test(item)) {
                        isData = 22;
                    }
                    return matcher.test(item);
                }
                else {
                    if (matcher2.test(item)) {
                        isData = 22;
                    }
                    return matcher2.test(item);
                }
            }));
            if (stringLength == 3 && isData == 1) {
                response($.grep(arr, function (item) {
                    return matcher2.test(item);
                }));
            }
        },
        minLength: 1,
    });
});
jQuery(function ($) {
    $("#datepicker").datepicker({
        minDate: 'D',
        dateFormat: "M-dd-yy",
        numberOfMonths: Resolution(),
        onClose: function (selectedDate) {
            $("#datepicker2").datepicker("option", "minDate", selectedDate);
            $("#datepicker2").select();
            return false;
        }
    });
});

jQuery(function ($) {
    $("#datepicker2").datepicker({
        minDate: '+1D',
        dateFormat: "M-dd-yy",
        numberOfMonths: Resolution(),
    });
});
$(document).ready(function () {
    $("#btm_clk").click(function () {
        $(".psg_dls").toggle(1000);
    });
    $(".btn_done").click(function () {

        var total = all_pesenger();
        $("#btm_clk").val(total + ' Passengers');
        $(".psg_dls").hide(1000);
    });
    $("#cls_clk").click(function () {
        $(".cls_dls").toggle(1000);
    });
    $(".btn_cls").click(function () {
        $('#cls_clk').val($('[name="classType"]:checked').val());
        $(".cls_dls").hide(1000);
    });
});
function show_date(data) {
    if (data == 'oneway') {
        $("#multi_cc").hide();
        $("#als_trips").show();
        $($("#roundtrip").parent()).removeClass('customradio');
        $($("#oneway").parent()).addClass('customradio');
        $('.colfade').addClass('colerfad');
        document.getElementById("datepicker2").disabled = true;
        var a = document.getElementById("datepicker2");
        a.removeAttribute("required");
    }
    else if (data == 'roundtrip') {
        $("#multi_cc").hide();
        $("#als_trips").show();
        $($("#oneway").parent()).removeClass('customradio');
        $($("#roundtrip").parent()).addClass('customradio');

        $('.colfade').removeClass('colerfad');
        document.getElementById("datepicker2").disabled = false;
        var b = document.getElementById("datepicker2");
        b.setAttribute("required", true);
    }
    else if (data == 'multi show') {
        $("#multi_cc").show();
        $("#als_trips").hide();
    }
}
function flight_form() {
    var loca = document.getElementById("locationd").value;
    var res = loca.substring(0, 3);
    document.getElementById("locationd").value = res;
    var loca = document.getElementById("locationd2").value;
    var res = loca.substring(0, 3);
    document.getElementById("locationd2").value = res;
    return true;
}

function QueryStringToJSON(location) {
    var pairs = location.slice(1).split('&');
    var result = {};
    pairs.forEach(function (pair) {
        pair = pair.split('=');
        result[pair[0]] = decodeURIComponent(pair[1] || '');
    });

    return JSON.stringify(result);
}
function setCookie() {
    var org = $('#locationd').val();
    //alert(org);
    var dest = $('#locationd2').val();
    var depart = $('#depDt').val();
    var arr = $('#retDt').val();
    var adt = $('#Adult').val();
    var chd = $('#Children').val();
    var inf = $('#Infant').val();
    var trip = $('.tripType').val();

    var tripType = "";
    try {
        if (document.getElementsByClassName('tripType')) {
            var airlineElements = document.getElementsByClassName('tripType');
            for (var i = 0; airlineElements[i]; ++i) {
                if (airlineElements[i].checked) {
                    //tripType.push(airlineElements[i].value); //for checkboxes
                    tripType = airlineElements[i].value;
                }
                //alert(filterAirlines);
            }
        }
    }
    catch (e) {}
    var formval = $('#frmsearch').serialize();
    var formjson = QueryStringToJSON(formval);
    var encjson = btoa(formjson);
    var skey = btoa('search' + Math.random());
    window.localStorage.setItem(skey, encjson);

    $(".waitingdiv").show();
    window.location.href = '/result?q=' + skey;
    return false;
}
function close_btn(id) {
    var array = id.split("_");
    var content = array[0];
    document.getElementById(content).value = '';
    document.getElementById(id).style.display = 'none';
    var label_id = content + '_label';
    if (content == 'location') {
        $('#' + label_id).html('City Name');
        $("#location").attr("placeholder", "Airport");

    } else if (content == 'location2') {
        $('#' + label_id).html('City Name');
        $("#location2").attr("placeholder", "Airport");

    }

}
$(document).ready(function () {
    $(".inp_fld_ps").click(function () {
        $("#box_px").toggle(1000);
    });
    $(".btn_done").click(function () {

        var total = all_pesenger();
        $("#txtclasstype").val(total + ' Passengers');
        $(".psg_dls").hide(1000);
    });
    $("#cls_clk").click(function () {
        $(".cls_dls").toggle(1000);
    });
    $(".btn_cls").click(function () {
        $('#cls_clk').val($('[name="classType"]:checked').val());
        $(".cls_dls").hide(1000);
    });
});
function all_pesenger() {
    var infow = $("#Infant").val();
    var childow = $("#Children").val();
    var adultow = $("#Adult").val();
    var total = +infow + +childow + +adultow;
    var strpx = adultow + ' Adults';
    if (childow > 0) { strpx += ', ' + childow + ' Children' }
    if (infow > 0) { strpx += ', ' + infow + ' Infants' }
    $('.inp_fld_ps').val(strpx);
    $('#box_px').hide(1000);
    return total;
}

function Resolution() {
    if (window.innerWidth < 780) {
        return 1;
    } else {
        return 1;
    }
}
