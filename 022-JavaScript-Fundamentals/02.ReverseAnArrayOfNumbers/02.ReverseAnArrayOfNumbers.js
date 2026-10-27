export function solve(n, inputArr) {
    let reverseArray = [];

    for (let i = 0; i < n; i++) {
        reverseArray.unshift(inputArr[i]);
    }

    console.log(reverseArray.join(' '));
}
