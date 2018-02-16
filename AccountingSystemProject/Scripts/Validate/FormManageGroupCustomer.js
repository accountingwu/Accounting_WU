$(document).ready(function () {


    $("#FormManageGroupCustomer").validate({
        rules: {
            gcuscode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            gcusname1: {
                required: true,
            }
        },
        messages: {
            gcuscode:
            {
                required: "กรุณากรอกรหัสกลุ่มลูกหนี้เป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            gcusname1:
            {
                required: "กรุณากรอกชื่อกลุ่มลูกหนี้"
            }


        }
    });

});