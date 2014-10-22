// Write a function that checks if the element at given 
// position in given array of integers is bigger than its 
// two neighbors (when such exist).


function onClick() {
    var sequence = document.getElementById("seq").value.split(/[\s,]+/);
    var position = parseInt(document.getElementById("pos").value);
    var result;

    if (position === sequence.length - 1 || position === 0) {
        result = "Number " + sequence[position] + " at position " + position + " has no two neighbours.";
    } else if (parseInt(position) > sequence.length - 1 || parseInt(position) < 0) {
        result = "The position " + position + " is outside of the boundaries of the array.";
    } else {
        result = check(sequence, position) ? "Number " + sequence[position] + " at position " + position + " is bigger thant its neighbours." :
                 "Number " + sequence[position] + " at position " + position + " is lesser than one or both of its neighbours";
    }
    document.getElementById("result").value = result;
}

function check(sequence, position) {
    if (parseInt(sequence[position]) > parseInt(sequence[position - 1]) &&
        parseInt(sequence[position]) > parseInt(sequence[position + 1])) {
        return true;
    } else {
        return false;
    }
}