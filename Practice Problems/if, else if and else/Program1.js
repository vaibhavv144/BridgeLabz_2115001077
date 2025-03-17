// 1. Program to Read a Single Digit Number and Write the Number in Word

// Function to convert a single digit number to its word representation
function numberToWord(num) {
    if (num === 0) {
        return "Zero";
    } else if (num === 1) {
        return "One";
    } else if (num === 2) {
        return "Two";
    } else if (num === 3) {
        return "Three";
    } else if (num === 4) {
        return "Four";
    } else if (num === 5) {
        return "Five";
    } else if (num === 6) {
        return "Six";
    } else if (num === 7) {
        return "Seven";
    } else if (num === 8) {
        return "Eight";
    } else if (num === 9) {
        return "Nine";
    } else {
        return "Not a single digit number";
    }
}

// Example usage
const singleDigit = parseInt(process.argv[2]); // Single digit number from command line
console.log(numberToWord(singleDigit));
