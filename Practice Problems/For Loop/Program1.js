// 1. Program to Print a Table of Powers of 2 Less Than or Equal to 2^n

// Function to print powers of 2 up to 2^n
function printPowersOfTwo(n) {
    for (let i = 0; i <= n; i++) {
        console.log(`2^${i} = ${Math.pow(2, i)}`);
    }
}

// Example usage
const n = parseInt(process.argv[2]); // Command-line argument
printPowersOfTwo(n);
