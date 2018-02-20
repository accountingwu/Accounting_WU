
$(document).ready(function () {


    $("#formBrach1").validate({
        rules: {
            bcode: {
                required: true,
                maxlength: 5 
                //letters: true
            },
            bname1: {
                required: true,
            }
        },
        messages: {
            bcode:
            {
                required: "กรุณากรอกรหัสสาขา",
                maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"
                /*maxlength: "กรุณาใส่ตัวเลขหรือตัวอักษรไม่เกิน 5 ตัว"*/,
                //letters: "กรุณากรอกตัวอักษรภาษาอังกฤษหรือตัวเลขเท่านั้น"
                //letters: "Please enter your SideCode"
            },
            bname1:
            {
                required: "กรุณากรอกชื่อสาขา"
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