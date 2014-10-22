// Write a function that returns the last digit of given 
// integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine"


function lastDigitAsString() {

    var number = parseInt(document.querySelector('#input').value);

    switch (number%10) {
        case 1:
            alert('The number is ONE');
            break;
        case 2: alert('The number is TWO');
            break;
        case 3: alert('The number is THREE');
            break;
        case 4: alert('The number is FOUR');
            break;
        case 5: alert('The number is FIVE');
            break;
        case 6: alert('The number is SIX');
            break;
        case 7: alert('The number is SEVEN');
            break;
        case 8: alert('The number is EIGHT');
            break;
        case 9: alert('The number is NINE');
            break;
        case 0: alert('The number is ZERO');
            break;
    default:
    }
}