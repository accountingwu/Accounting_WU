
$(document).ready(function () {

    $("#SectionFrom").validate({
        rules: {
            secode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            sename1: {
                required: true,
            }
        },
        messages: {
            dcode: {
                required: "กรุณากรอกรหัสแผนก",
            },
            secode:
            {
                required: "กรุณากรอกรหัสแผนก",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
            },
            sename1:
            {
                required: "กรุณากรอกชื่อแผนก"
            }


        }
    });

});
