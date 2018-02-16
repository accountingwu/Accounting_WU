$(document).ready(function () {


    $("#FormEmployeeGroup").validate({
        rules: {
            EmCode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            EmGroupName: {
                required: true,
            }
        },
        messages: {
            EmCode:
            {
                required: "กรุณากรอกรหัสกลุ่มพนักงานเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            EmGroupName:
            {
                required: "กรุณากรอกชื่อกลุ่มพนักงาน"
            }


        }
    });

});