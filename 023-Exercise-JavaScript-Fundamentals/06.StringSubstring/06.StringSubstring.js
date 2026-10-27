export function solve(word, text) {
    const hasWord = text
    .toLowerCase()
    .split(' ')
    .includes(word.toLowerCase());

    if (hasWord) {
        console.log(word);
    }
    else {
        console.log(`${word} not found!`)
    }
}
