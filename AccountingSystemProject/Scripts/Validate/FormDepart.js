$(document).ready(function () {


    $("#FormDepart").validate({
        rules: {
            dcode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            dname1: {
                required: true,
            }
        },
        messages: {
            dcode:
            {
                required: "กรุณากรอกรหัสฝ่ายเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            dname1:
            {
                required: "กรุณากรอกชื่อฝ่าย"
            }
             
            
        }
    });

});