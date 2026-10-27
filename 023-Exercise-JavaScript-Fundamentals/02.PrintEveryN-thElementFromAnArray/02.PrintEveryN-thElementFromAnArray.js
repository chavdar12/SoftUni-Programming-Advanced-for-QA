export function solve(arrayOfStrings, step) {
    
    const result = [];

    for (let i = 0; i < arrayOfStrings.length; i+=step){
        result.push(arrayOfStrings[i]);
    }

    return result;
}
