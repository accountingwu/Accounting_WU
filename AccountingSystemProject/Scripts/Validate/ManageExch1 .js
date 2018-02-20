
$(document).ready(function () {

    $("#ExchFrom").validate({
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
                required: "กรุณากรอกรหัสค่าใช้จ่าย",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
            },
            ExpnName:
            {
                required: "กรุณากรอกชื่อค่าใช้จ่าย"
            },
             AccCode:
            {
                required: "กรุณาเลือกรหัสบัญชี"
            }


        }
    });

});
