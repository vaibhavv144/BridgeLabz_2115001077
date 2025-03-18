function primeFactors(n) {
    const factors = [];
   
    // Check for number of 2s that divide n
    while (n % 2 === 0) {
        factors.push(2);
        n /= 2;
    }

    // n must be odd at this point, so we can skip even numbers
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n /= i;
        }
    }

    // This condition is to check if n is a prime number greater than 2
    if (n > 2) {
        factors.push(n);
    }

    console.log(`Prime factors of the number: ${factors}`);
}

// Example usage
const n = parseInt(process.argv[2]); // Command-line argument
if (isNaN(n) || n <= 0) {
    console.log("Please provide a valid positive integer.");
} else {
    primeFactors(n);
}

