// 1. Program to Read a Single Digit Number and Write the Number in Word Using Case

// Function to convert a single digit number to its word representation using switch
function numberToWord(num) {
    switch (num) {
        case 0:
            return "Zero";
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        case 4:
            return "Four";
        case 5:
            return "Five";
        case 6:
            return "Six";
        case 7:
            return "Seven";
        case 8:
            return "Eight";
        case 9:
            return "Nine";
        default:
            return "Not a single digit number";
    }
}

// Example usage
const singleDigit = parseInt(process.argv[2]); // Single digit number from command line
console.log(numberToWord(singleDigit));
