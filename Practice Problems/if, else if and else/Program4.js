// 4. Program to Enter 3 Numbers and Perform Arithmetic Operations to Find Maximum and Minimum

// Function to perform arithmetic operations and find max and min
function findMaxMin(a, b, c) {
    const results = [
        a + b * c,
        a % b + c,
        c + a / b,
        a * b + c
    ];

    const max = Math.max(...results);
    const min = Math.min(...results);

    console.log("Results of operations: ", results);
    console.log("Maximum Value: ", max);
    console.log("Minimum Value: ", min);
}


const a = parseFloat(process.argv[2]); // First number from command line
const b = parseFloat(process.argv[3]); // Second number from command line
const c = parseFloat(process.argv[4]); // Third number from command line
findMaxMin(a, b, c);
