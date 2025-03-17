// 2. Program to Read a Number and Display the Week Day

// Function to convert a number to a weekday
function numberToWeekday(num) {
    if (num === 0) {
        return "Sunday";
    } else if (num === 1) {
        return "Monday";
    } else if (num === 2) {
        return "Tuesday";
    } else if (num === 3) {
        return "Wednesday";
    } else if (num === 4) {
        return "Thursday";
    } else if (num === 5) {
        return "Friday";
    } else if (num === 6) {
        return "Saturday";
    } else {
        return "Not a valid day number (0-6)";
    }
}

// Example usage
const dayNumber = parseInt(process.argv[2]); // Day number from command line
console.log(numberToWeekday(dayNumber));
