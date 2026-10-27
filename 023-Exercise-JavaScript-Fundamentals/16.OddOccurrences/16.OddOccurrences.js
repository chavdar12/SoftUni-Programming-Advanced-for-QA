export function solve(input) {
    // Map keeps insertion order; a plain object would list numeric words like '1' first.
    const wordOccurrences = new Map();

    for (const word of input.toLowerCase().split(' ')) {
        wordOccurrences.set(word, (wordOccurrences.get(word) ?? 0) + 1);
    }

    return [...wordOccurrences]
        .filter(([, count]) => count % 2 !== 0)
        .map(([word]) => word)
        .join(' ');
}
