// Write a function that returns the index of the first 
// element in array that is bigger than its neighbors, or -1, 
// if there’s no such element.
// Use the function from the previous exercise.


function onClick() {
    var sequence = document.getElementById("seq").value.split(/[\s,]+/);

    for (var i = 0; i < sequence.length; i++) {
        if (check(sequence,i)) {

            document.getElementById("result").value = 'The index if the first element bigger ' +
                'than its neghbors is:' + i;
            break;
        }
    }
}

function check(sequence, position) {
    if (parseInt(sequence[position]) > parseInt(sequence[position - 1]) &&
        parseInt(sequence[position]) > parseInt(sequence[position + 1])) {
        return true;
    } else {
        return false;
    }
}

