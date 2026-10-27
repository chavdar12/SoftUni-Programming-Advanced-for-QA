export function solve(text, bannedWord) {
    function repeat(count) {
        return '*'.repeat(count);
    }
    
    let censored = text.replace(bannedWord, repeat(bannedWord.length));

    while (censored.includes(bannedWord)) {
        censored = censored.replace(bannedWord, repeat(bannedWord.length));
    }

    console.log(censored);
}
