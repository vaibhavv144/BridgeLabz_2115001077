// 2. Program to Find the Magic Number

// Function to find the magic number
function findMagicNumber() {
    const magicNumber = Math.floor(Math.random() * 100) + 1; // Random number between 1 and 100
    let guess = 0;

    console.log("Think of a number between 1 and 100.");

    while (guess !== magicNumber) {
        guess = parseInt(prompt("Is your number less than, greater than, or equal to " + magicNumber + "? (Enter 'less', 'greater', or 'equal')"));

        if (guess === 'less') {
            console.log("Your number is less than " + magicNumber);
            magicNumber = Math.floor(magicNumber / 2); // Adjust the magic number
        } else if (guess === 'greater') {
            console.log("Your number is greater than " + magicNumber);
            magicNumber = Math.floor(magicNumber + (100 - magicNumber) / 2); // Adjust the magic number
        } else if (guess === 'equal') {
            console.log("Magic Number Found: " + magicNumber);
            break;
        } else {
            console.log("Invalid input. Please enter 'less', 'greater', or 'equal'.");
        }
    }
}

// Call the function
findMagicNumber();
