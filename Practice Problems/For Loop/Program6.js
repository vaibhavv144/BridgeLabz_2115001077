// 6. Program to Compute Factors of a Number Using Prime Factorization Method

// Function to compute prime factors of a number using prime factorization method
function primeFactors(n) {
    console.log(`Prime factors of ${n}:`);
    
    // Check for number of 2s that divide n
    while (n % 2 === 0) {
        console.log(2);
        n /= 2;
    }

    // n must be odd at this point, so we can skip even numbers
    for (let i = 3; i * i <= n; i += 2) {
        // While i divides n, print i and divide n
        while (n % i === 0) {
            console.log(i);
            n /= i;
        }
    }

    // This condition is to check if n is a prime number greater than 2
    if (n > 2) {
        console.log(n);
    }
}


const n = parseInt(process.argv[2]); // Command-line argument
if (isNaN(n) || n <= 0) {
    console.log("Please provide a valid positive integer.");
} else {
    primeFactors(n);
}

