$(document).ready(function () {


    $("#FormProductGroup").validate({
        rules: {
            grpcode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            grpname1: {
                required: true,
            }
        },
        messages: {
            grpcode:
            {
                required: "กรุณากรอกรหัสกลุ่มสินค้าเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            grpname1:
            {
                required: "กรุณากรอกชื่อกลุ่มสินค้า"
            }


        }
    });

});