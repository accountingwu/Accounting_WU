
$(document).ready(function () {

    $("#ExpnFrom").validate({
        rules: {
            AccCode: {
                required: true,
              
            },
            ExpnCode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            ExpnName: {
                required: true,
            }
        },
        messages: {
            ExpnCode:
            {
                required: "กรุณากรอกรหัสรายได้",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
            },
            ExpnName:
            {
                required: "กรุณากรอกชื่อรายได้"
            },
             AccCode:
            {
                required: "กรุณาเลือกรหัสบัญชี"
            }


        }
    });

});
