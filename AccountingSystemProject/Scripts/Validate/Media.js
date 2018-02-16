
$(document).ready(function () {


    $("#FormCustMedia").validate({
        rules: {
            CustMediaCode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            CustMediaName: {
                required: true,
            }
        },
        messages: {
            CustMediaCode:
            {
                required: "กรุณากรอกรหัสแหล่งข้อมูลลูกค้าเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            CustMediaName:
            {
                required: "กรุณากรอกชื่อแหล่งข้อมูลลูกค้า"
            }
             
            
        }
    });

});
