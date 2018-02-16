$(document).ready(function () {


    $("#FormBadScrap").validate({
        rules: {
            scode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            scname1: {
                required: true,
            }
        },
        messages: {
            scode:
            {
                required: "กรุณากรอกรหัสสาเหตุของเสียเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            scname1:
            {
                required: "กรุณากรอกชื่อสาเหตุของเสีย"
            }


        }
    });

});