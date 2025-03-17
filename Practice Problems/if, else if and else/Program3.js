// 3. Program to Read a Number and Display Unit, Ten, Hundred, etc.

// Function to determine the place value of a number
function placeValue(num) {
    if (num === 1) {
        return "Unit";
    } else if (num === 10) {
        return "Ten";
    } else if (num === 100) {
        return "Hundred";
    } else if (num === 1000) {
        return "Thousand";
    } else {
        return "Not a valid place value (1, 10, 100, 1000)";
    }
}


const placeNumber = parseInt(process.argv[2]); // Place value number from command line
console.log(placeValue(placeNumber));
