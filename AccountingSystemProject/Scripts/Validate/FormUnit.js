$(document).ready(function () {


    $("#FormUnit").validate({
        rules: {
            ucode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            uname1: {
                required: true,
            }
        },
        messages: {
            ucode:
            {
                required: "กรุณากรอกรหัสหน่วยนับ",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            uname1:
            {
                required: "กรุณากรอกชื่อหน่วยนับ"
            }


        }
    });

});