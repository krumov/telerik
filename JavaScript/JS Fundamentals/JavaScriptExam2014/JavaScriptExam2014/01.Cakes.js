function solve(inputArr) {
    //var inputArr = [
    //    110,
    //    13,
    //    15,
    //    17
    //];

    var amountOfMoney = inputArr[0],
        cakeOnePrice = inputArr[1],
        cakeTwoPrice = inputArr[2],
        cakeThreePrice = inputArr[3],

        sum = 0;

    var maxSum = 0;

    for (var i = 0; i < Math.floor(amountOfMoney / cakeOnePrice) ; i++) {
        for (var j = 0; j < Math.floor(amountOfMoney / cakeTwoPrice) ; j++) {
            for (var k = 0; k < Math.floor(amountOfMoney / cakeThreePrice) ; k++) {
                sum = i * cakeOnePrice + j * cakeTwoPrice + k * cakeThreePrice;
                if (sum > maxSum && sum<=amountOfMoney) {
                    maxSum = sum;
                }
            }
        }
    }

  
    console.log(maxSum);
}
