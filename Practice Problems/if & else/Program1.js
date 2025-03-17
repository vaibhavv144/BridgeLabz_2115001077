// 1. Program to Read 5 Random 3-Digit Values and Output Minimum and Maximum

// Function to generate 5 random 3-digit numbers and find min and max
function findMinMax() {
    let numbers = [];
    
    // Generate 5 random 3-digit numbers
    for (let i = 0; i < 5; i++) {
        let randomNum = Math.floor(Math.random() * 900) + 100; // Random 3-digit number
        numbers.push(randomNum);
    }
    
    // Find minimum and maximum values
    let min = Math.min(...numbers);
    let max = Math.max(...numbers);
    
    console.log("Random Numbers: ", numbers);
    console.log("Minimum Value: ", min);
    console.log("Maximum Value: ", max);
}

findMinMax();

