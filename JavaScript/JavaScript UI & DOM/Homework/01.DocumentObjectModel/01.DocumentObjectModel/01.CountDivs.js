// Write a script that selects all the div nodes that are 
// directly inside other div elements
// - Create a function using querySelectorAll()
// - Create a function using getElementsByTagName()


function queryCheck() {
    var querryDivs = document.querySelectorAll('div>div');

    alert('There are ' + querryDivs.length +' divs that are directly insade other divs')
}

function getElementsCheck() {
    var wrapperDivLive = document.getElementsByTagName('div');
    var innerDivLive = [];

    for (var i = 0, length = wrapperDivLive.length; i < length; i++) {
        innerDivLive.push(wrapperDivLive[i].getElementsByTagName('div'));
    }

    var numOfDivs = innerDivLive[0].length;

    alert('There are ' + numOfDivs + ' divs that are directly insade other divs')

}