var students = [{fname: "Todor", lname: "Ivanov", age: 17, marksAverage: 5.25},
        {fname: "Petra", lname: "Georgieva", age: 22, marksAverage: 4.46},
        {fname: "Zina", lname: "Georgieva", age: 28, marksAverage: 4.26},
        {fname: "Ivan", lname: "Petrov", age: 24, marksAverage: 5.65},
        {fname: "Ivan", lname: "Deanov", age: 21, marksAverage: 5.15},
        {fname: "Stamina", lname: "Staminova", age: 45, marksAverage: 3.98}],
    animals = [{animal: "donkey", species: "mamal", legN: 4},
        {animal: "horse", species: "mamal", legN: 4},
        {animal: "spider", species: "insect", legN: 8},
        {animal: "centipede", species: "insect", legN: 100},
        {animal: "fly", species: "insect", legN: 6},
        {animal: "cow", species: "mamal", legN: 4}]
    books = [{title: "The trhee musketiers", author: "Alexander Duma"},
        {title: "20 years later", author: "Alexander Duma"},
        {title: "Airport", author: "Arthur Heily"}];

function task1(){
    var  strToPrint = new String();
    var result =_.filter(students,function(ev){return ev.fname < ev.lname})
    _.sortBy(students,function(ev){ev.fname+ev.lname})
    _.each(result.reverse(),function(item){strToPrint += item.fname +" "+ item.lname + "<br>"});
    printResult(strToPrint);
}

function task2(){
    var  strToPrint = new String();
    var result =_.filter(students, function(ev){return ev.age >= 18 && ev.age <= 24})
    _.each(result,function(item){strToPrint += item.fname +" "+ item.lname + ": " + item.age + " years old<br>"});
    printResult(strToPrint);
}

function task3(){
    var result = _.max(students, function(student){return student.marksAverage});
    printResult(result.fname +" "+ result.lname + ": " + result.marksAverage + " marks average");
}

function task4(){
    var result =_.sortBy(animals,"legN")
    _.groupBy(result,"species");
    console.log(result);
    printResult("See in the console :)");
}

function task5(){
    var result=0;
    _.each(animals, function(ev){result += ev.legN});
    printResult(result);
}

function task6(){
    var countByAuthor, index, result;
    countByAuthor = _.countBy(books,"author")
    index = _.max(countByAuthor);
    printResult(_.invert(countByAuthor)[index]);
}

function task7(){
    var firstName, lastName, indexFirstName, indexLastName;
    firstName = _.countBy(students,"fname"),
        indexFirstName = _.max(firstName);
    lastName = _.countBy(students,"lname");
    indexLastName = _.max(lastName);
    printResult("Most frequent first name: " + _.invert(firstName)[indexFirstName] +
        "<br>Most frequent last name: " + _.invert(lastName)[indexLastName]);
}

function printResult(result){
    var outBox = document.getElementById("field");
    outBox.innerHTML = result;
}