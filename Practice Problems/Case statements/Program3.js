// 3. Program to Read a Number and Display Unit, Ten, Hundred, etc.

// Function to determine the place value of a number using switch
function placeValue(num) {
    switch (num) {
        case 1:
            return "Unit";
        case 10:
            return "Ten";
        case 100:
            return "Hundred";
        case 1000:
            return "Thousand";
        default:
            return "Not a valid place value (1, 10, 100, 1000)";
    }
}

// Example usage
const placeNumber = parseInt(process.argv[2]); // Place value number from command line
console.log(placeValue(placeNumber));
