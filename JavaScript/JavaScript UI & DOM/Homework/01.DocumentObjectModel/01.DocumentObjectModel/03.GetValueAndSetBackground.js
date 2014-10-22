// Crеate a function that gets the value of <input type="color">
// and sets the background of the body to this value


function setBackground() {
    var color = document.querySelector('#colorField').value;

    return document.body.style.backgroundColor = color;

    // ако ми кажеш защо страницата рефрешва при натискане на бутона ще съм 
    // много благодарен :)
}
