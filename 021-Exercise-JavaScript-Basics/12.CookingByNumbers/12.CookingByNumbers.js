export function solve(rawNumber, firstOperation, secondOperation, thirdOperation, forthOperation, fifthOperation) {
    let number = parseInt(rawNumber);

    function executeOps(currentNum, currentOperation) {

        if (currentOperation === 'chop') {
            return currentNum / 2;
        }
        else if (currentOperation === 'dice') {
            return Math.sqrt(currentNum);
        }
        else if (currentOperation === 'spice') {
            return currentNum + 1;
        }
        else if (currentOperation === 'bake') {
            return currentNum * 3;
        }
        else if (currentOperation === 'fillet') {
            return currentNum - currentNum * 0.2;
        }
        else {
            return currentNum;
        }
    }

    number = executeOps(number, firstOperation);
    console.log(number);

    number = executeOps(number, secondOperation);
    console.log(number);

    number = executeOps(number, thirdOperation);
    console.log(number);

    number = executeOps(number, forthOperation);
    console.log(number);

    number = executeOps(number, fifthOperation);
    console.log(number);
}
