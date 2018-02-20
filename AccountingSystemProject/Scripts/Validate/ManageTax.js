
$(document).ready(function () {

    $("#vatgroupfrom").validate({
        rules: {
            VATGroupCode: {
                required: true,
            
                //letters: true
            },
            AccCode: {
                required: true,
            },
            VatRate: {
                required: true,
            }
        },
        messages: {
            VATGroupCode: {
                required: "กรุณากรอกรหัสภาษี",
            },
            AccCode:
            {
                required: "กรุณากรอกรหัสบัญชี",
               
            },
            VatRate:
            {
                required: "กรุณากรอกอัตรภาษี",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
            }


        }
    });

});
