
$(document).ready(function () {
    $('#companyfrom').validate({
        ignore: [],
        invalidHandler: function (e, validator) {
            if (validator.errorList.length) {
                //debugger;
                $('#tabs a[href="#' + jQuery(validator.errorList[0].element).closest(".tab-pane").attr('id') + '"]').tab('show')

            }
        }
    });

    //add click event to the form's button
    $('#Save button').click(function (evt) {
        evt.preventDefault();
        $('#companyfrom').submit()


    });
});
