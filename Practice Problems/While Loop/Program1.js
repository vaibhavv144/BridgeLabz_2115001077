// 1. Program to Print a Table of Powers of 2 Less Than or Equal to 2^n Until 256 is Reached

// Function to print powers of 2 until 256 is reached
function printPowersOfTwo(n) {
    let i = 0;
    let power = Math.pow(2, i);
    
    while (power <= 256 && i <= n) {
        console.log(`2^${i} = ${power}`);
        i++;
        power = Math.pow(2, i);
    }
}

// Example usage
const n = parseInt(process.argv[2]); // Command-line argument
printPowersOfTwo(n);
