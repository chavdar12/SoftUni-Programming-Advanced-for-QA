export function solve(object) {
    for (let key in object) {
        console.log(`${key} -> ${object[key]}`);
    }
}
