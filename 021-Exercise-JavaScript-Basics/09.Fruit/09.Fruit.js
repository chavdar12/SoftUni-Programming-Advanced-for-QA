export function solve(fruit, weightInGrams, pricePerKg) {
    const pricePerGram = pricePerKg / 1000;
    const totalPrice = weightInGrams * pricePerGram;
    const weightInKg = weightInGrams / 1000;
    
    console.log(`I need $${totalPrice.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`)
}
