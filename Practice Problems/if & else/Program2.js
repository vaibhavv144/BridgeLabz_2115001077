// 2. Program to Check if Day of Month is Between March 20 and June 20

// Function to check if the given day and month is between March 20 and June 20
function isDateInRange(day, month) {
    // Convert month to a number (March = 3, June = 6)
    if (month < 3 || month > 6) {
        return false; // Outside the range
    } else if (month === 3 && day < 20) {
        return false; // Before March 20
    } else if (month === 6 && day > 20) {
        return false; // After June 20
    }
    return true; // Within the range
}

// Example usage
const day = parseInt(process.argv[2]); // Day from command line
const month = parseInt(process.argv[3]); // Month from command line
console.log(isDateInRange(day, month));
