// 3. Program to Determine if a Number is Prime

// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// Example usage
const num = parseInt(process.argv[2]); // Command-line argument
console.log(`${num} is ${isPrime(num) ? 'a Prime Number' : 'not a Prime Number'}`);
