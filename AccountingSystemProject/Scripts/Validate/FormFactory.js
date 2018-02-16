$(document).ready(function () {


    $("#FormFactory").validate({
        rules: {
            fcode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            fname1: {
                required: true,
            }
        },
        messages: {
            fcode:
            {
                required: "กรุณากรอกรหัสโรงงานเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            fname1:
            {
                required: "กรุณากรอกชื่อชื่อโรงงาน"
            }


        }
    });
});