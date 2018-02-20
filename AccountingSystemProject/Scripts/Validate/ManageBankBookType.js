
////jQuery.validator.addMethod("letters", function (value, element) {
////    return this.optional(element) || value == value.match(/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@(?:\S{1,63})$/);
////}, "*กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น");  



$(document).ready(function () {


    // validate signup form on keyup and submit

    $("#ManageBankBookType").validate({
        rules: {
            BookTypeCode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            BookTypeName: {
                required: true,
            }
        },
        messages: {
            BookTypeCode:
            {
                required: "กรุณากรอกรหัสประเภทสมุดเงินฝากเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
           BookTypeName:
            {
                required: "กรุณากรอกชื่อประเภทสมุดเงินฝาก"
            }
             
            
        }
    });

});


