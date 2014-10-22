function Solve(params) {

  // var params = [
  //'3 5',
  //'54561',
  //'43328',
  //'52388',
  //  ];


    var sizeOfField = params[0].split(' ');
    var rows = parseInt(sizeOfField[0]),
        cols = parseInt(sizeOfField[1]),
        row = rows-1,
        col = cols-1,
        directionsArr = params.slice(1);

    var sum = 0;
    var count = 0;

    function getValueAt(row, col) {
        return Math.pow(2,row) - 1*col;
    }

    function changeDir(direction) {
        switch (direction) {
            case '1':
                row -= 2, col += 1;
                break;
            case '2':
                row -= 1, col += 2;
                break;
            case '3':
                row += 1, col += 2;
                break;
            case '4':
                row += 2, col += 1;
                break;
            case '5':
                row += 2, col -= 1;
                break;
            case '6':
                row += 1, col -= 2;
                break;
            case '7':
                row -= 1, col -= 2;
                break;
            case '8':
                row -= 2, col -= 1;
                break;
            default:
        }
    }

    var used = [];
    
    for (var i = 0; i < rows; i++) {
        used[i] = [];
        for (var j = 0; j < cols; j++) {
            used[i][j] = false;
        }
    }

    var direction = '';

    while (0 <= row && row < rows && 0 <= col && col < cols) {
        var cellValue = getValueAt(row, col);
        if (used[row][col]) {
            //return 'Sadly the horse is doomed in ' + count + ' jumps';
            return 'Sadly the horse is doomed in ' + count + ' jumps';
        }

        direction = directionsArr[row][col];
        sum += cellValue;
        used[row][col] = true;
        count++;
        changeDir(direction);
    }

    return 'Go go Horsy! Collected ' + sum + ' weeds';

}
