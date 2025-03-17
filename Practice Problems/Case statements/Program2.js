// 2. Program to Read a Number and Display the Week Day

// Function to convert a number to a weekday using switch
function numberToWeekday(num) {
    switch (num) {
        case 0:
            return "Sunday";
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        default:
            return "Not a valid day number (0-6)";
    }
}

// Example usage
const dayNumber = parseInt(process.argv[2]); // Day number from command line
console.log(numberToWeekday(dayNumber));
