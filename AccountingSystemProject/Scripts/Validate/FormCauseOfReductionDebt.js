$(document).ready(function () {


    $("#FormCauseOfReductionDebt").validate({
        rules: {
            CNRemarkTypeCode: {
                required: true,
                maxlength: 5
                //letters: true
            },
            CNRemarkTypeName1: {
                required: true,
            }
        },
        messages: {
            CNRemarkTypeCode:
            {
                required: "กรุณากรอกรหัสสาเหตุลดหนี้ เพิ่มหนี้เป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            CNRemarkTypeName1:
            {
                required: "กรุณากรอกชื่อสาเหตุลดหนี้ เพิ่มหนี้"
            }


        }
    });

});