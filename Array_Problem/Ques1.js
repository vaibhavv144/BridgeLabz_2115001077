function findSecondLargestAndSmallest() {
    const numbers = [];
   
    // Generate 10 random 3-digit numbers
    for (let i = 0; i < 10; i++) {
        const randomNum = Math.floor(Math.random() * 900) + 100; // Random 3-digit number
        numbers.push(randomNum);
    }

    console.log("Random Numbers: ", numbers);

    let largest = -Infinity;
    let secondLargest = -Infinity;
    let smallest = Infinity;
    let secondSmallest = Infinity;

    for (const num of numbers) {
        // Find 2nd largest
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num < largest) {
            secondLargest = num;
        }

        // Find 2nd smallest
        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num > smallest) {
            secondSmallest = num;
        }
    }

    console.log("2nd Largest: ", secondLargest);
    console.log("2nd Smallest: ", secondSmallest);
}

// Call the function
findSecondLargestAndSmallest();

