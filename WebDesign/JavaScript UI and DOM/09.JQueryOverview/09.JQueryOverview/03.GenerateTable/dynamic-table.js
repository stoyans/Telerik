/// <reference path="_references.js" />

var students = [
    { firstName: "Petar", lastName: "Ivanov", grade: 3 },
    { firstName: "Milena", lastName: "Grigorova", grade: 6 },
    { firstName: "Gergana", lastName: "Borisova", grade: 12 },
    { firstName: "Boyko", lastName: "Petrov", grade: 9 }
];
var table = $("<table>");
table.css({
    "border": "1px solid black",
})
table.attr("border", "1");

$("<button>")
    .html("Generate Table")
    .attr('id', 'get-table')
    .appendTo(document.body)
    .click(function () {
        table.append("<tr><th>First Name <th>Last Name</th><th>Grade</th>")

        for (var i = 0; i < students.length; i++) {
            table.append("<tr><td>" + students[i].firstName + "<td>" + students[i].lastName + "<td>" + students[i].grade + "</tr>")

        }
        
        table.appendTo(document.body);
    })

