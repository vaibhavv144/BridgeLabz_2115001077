// 3. Write a program that takes a year as input and outputs the Year is a Leap Year or not
// a Leap Year. A Leap Year checks for 4 Digit Number, Divisible by 4 and not 100 unless
// divisible by 400.

// Function to check if a year is a leap year
function isLeapYear(year) {
    if (year % 4 === 0) {
        if (year % 100 === 0) {
            if (year % 400 === 0) {
                return true; // Divisible by 400
            }
            return false; // Divisible by 100 but not by 400
        }
        return true; // Divisible by 4 but not by 100
    }
    return false; // Not divisible by 4
}

// Example usage
const year = parseInt(process.argv[2]); // Year from command line

if (isNaN(year)) {
    console.log("Please provide a valid year.");
} else {
    if (isLeapYear(year)) {
        console.log(year + " is a Leap Year.");
    } else {
        console.log(year + " is not a Leap Year.");
    }
}
