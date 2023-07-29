// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//  --- Create Grade ---  //  ------------------------------------------------------------------------------Create Grade

function createGrade() {
    var grade = $("#gradesNumber").val();
console.log(grade);
    if (grade == null) {
        return JSON.stringify({
            Error: true,
            Message: "Əlavə olunacaq sinifi daxil edin"
        });
    }else if(grade < 1 || grade > 12){
        return JSON.stringify({
            Error: true,
            Message: "Siniflər 0-dan aşağı və ya 11dən yuxarı ola bilməz"
        });
    }

    $.ajax({
        url: '/Admin/Create/',
        type: 'POST',
        datatype: 'application/json',
        contentType: 'application/json',
        data: JSON.stringify({
            grade: grade
        }),
        success: function (result) {
            messageDialog(result.Message, result.Error);
            
        },
        error: function () {
            messageDialog('Əməliyyat uğursuz oldu.', true);
        }
    });
}




























