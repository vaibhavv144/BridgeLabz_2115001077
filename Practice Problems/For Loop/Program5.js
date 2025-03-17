// 5. Program to Compute the Factorial of a Number

// Function to compute factorial of a number
function factorial(n) {
    let result = 1;
    for (let i = 1; i <= n; i++) {
        result *= i;
    }
    return result;
}

// Example usage
const n = parseInt(process.argv[2]); // Command-line argument
console.log(`Factorial of ${n} = ${factorial(n)}`);
