// 2. Program to Print the nth Harmonic Number

// Function to calculate the nth harmonic number
function harmonicNumber(n) {
    let harmonic = 0;
    for (let i = 1; i <= n; i++) {
        harmonic += 1 / i;
    }
    return harmonic;
}

// Example usage
const n = parseInt(process.argv[2]); // Command-line argument
console.log(`Harmonic Number H(${n}) = ${harmonicNumber(n)}`);
