
////jQuery.validator.addMethod("letters", function (value, element) {
////    return this.optional(element) || value == value.match(/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@(?:\S{1,63})$/);
////}, "*กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น");  



$(document).ready(function () {

    //$.validator.addMethod("letters", function (value, element)
    //{
    //    return this.optional(element) || value == value.match(/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@(?:\S{1,63})$/);
    //});

    // validate signup form on keyup and submit

    $("#FormCustMedia").validate({
        rules: {
            TranspAreaCode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            TranspAreaName: {
                required: true,
            }
        },
        messages: {
            TranspAreaCode:
            {
                required: "กรุณากรอกรหัสเขตการขนส่งเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            TranspAreaName:
            {
                required: "กรุณากรอกชื่อเขตการขนส่ง"
            }
             
            
        }
    });

});
//$(document).ready(function (){



//    $.validator.addMethod("lettersonly", function (value, element) {
//        return this.optional(element) || /^[a-z\s]*$/i.test(value);
//    }, "Please enter only letters");

//    //$.validator.addMethod('strongPassword', function (value, element) {
//    //    return this.optional(element)
//    //        || value.length >= 6
//    //        && /\d/.test(value)
//    //        && /[a-z]/i.test(value);
//    //}, 'Your password is too weak.')

//    $("formside").validate({
//        errorClass: "error-class",
//        //validClass: "valid-class",
//        rules: {
//            SideCode: {
//                required: true,
//                maxlength: 5 ,
//                lettersonly: true
//            },

//            SideName: {
//                required: true,
//            }
//        },

//        messages: {

//            SideName: {
//                required: "กรุณากรอกชื่อฝ่าย."
//            },
//            SideCode:
//            {
//                //required: "กรุณากรอกรหัสฝ่ายเป็นภาษาอังกฤษและตัวเลขเท่านั้น",
//                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
//                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
//                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
//                //letters: "Please enter your SideCode"
//            },
//        }

//    });
//});