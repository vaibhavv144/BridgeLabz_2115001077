// 4. Program to Output Prime Numbers in a Given Range

// Function to print prime numbers in a given range
function printPrimesInRange(start, end) {
    for (let num = start; num <= end; num++) {
        if (isPrime(num)) {
            console.log(num);
        }
    }
}

// Example usage
const start = parseInt(process.argv[2]); // Start of range
const end = parseInt(process.argv[3]); // End of range
printPrimesInRange(start, end);
