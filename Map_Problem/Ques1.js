function rollDie() {
    const results = new Map();
    let maxCount = 0;
    let minCount = Infinity;
    let maxNumber = null;
    let minNumber = null;

    // Initialize the map with numbers 1 to 6
    for (let i = 1; i <= 6; i++) {
        results.set(i, 0);
    }

    // Roll the die until one number reaches 10 times
    while (maxCount < 10) {
        const roll = Math.floor(Math.random() * 6) + 1; // Roll a die (1-6)
        results.set(roll, results.get(roll) + 1); // Increment the count for the rolled number

        // Update max and min counts
        if (results.get(roll) > maxCount) {
            maxCount = results.get(roll);
            maxNumber = roll;
        }
        if (results.get(roll) < minCount) {
            minCount = results.get(roll);
            minNumber = roll;
        }
    }

    console.log("Die Roll Results: ", results);
    console.log(`Number that reached maximum times: ${maxNumber} (${maxCount} times)`);
    console.log(`Number that reached minimum times: ${minNumber} (${minCount} times)`);
}

// Call the function
rollDie();
