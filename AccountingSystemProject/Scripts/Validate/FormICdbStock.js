$(document).ready(function () {


    $("#FormICdbStock").validate({
        rules: {
            wcode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            wname1: {
                required: true
            },
            bcode: {
                required: true
            },
            wtype: {
                required: true
            }
        },
        messages: {
            wcode:
            {
                required: "กรุณากรอกรหัสคลังสินค้า",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            wname1:
            {
                required: "กรุณากรอกชื่อคลังสินค้า"
            },
            bcode:
            {
                required: "กรุณาเลือกสาขา"
            },
            wtype:
            {
                required: "กรุณาเลือกประเภทคลังสินค้า"
            }
        }
    });

});