var students = [{
    firstName: 'Peter',
    lastName: 'Ivanov',
    grade: 3
}, {
    firstName: 'Milena',
    lastName: 'Grigorova',
    grade: 6
}, {
    firstName: 'Gergana',
    lastName: 'Borisova',
    grade: 12
}, {
    firstName: 'Boyko',
    lastName: 'Petrov',
    grade: 7
}];

$(document).ready(function(){

    var $table = $('<table><tr><th>First Name</th><th>Last Name</th><th>Grade</th></tr></table>');

    for (var i = 0; i < students.length; i++) {
        $table.append(createRow(students[i]));
    }

    function createRow(student){
        var $row = $('<tr><td>' + student.firstName + '</td><td>'+ student.lastName +'</td><td>'+ student.grade +'</td></tr>');

        return $row;
    }

    $('body').append($table);
})