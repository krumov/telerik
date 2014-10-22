// Write a function to count the number of divs on the web page


countDivs();

function countDivs() {
    var count = document.getElementsByTagName('div').length;

    alert("The number of divs in your page is " + count);
}