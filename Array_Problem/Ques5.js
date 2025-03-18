function findRepeatedDigits() {
    const repeatedDigits = [];

    for (let i = 0; i <= 100; i++) {
        const strNum = i.toString();
        const digitCount = {};

        for (const digit of strNum) {
            digitCount[digit] = (digitCount[digit] || 0) + 1;
        }

        for (const digit in digitCount) {
            if (digitCount[digit] === 2) {
                repeatedDigits.push(strNum);
                break; // Only need to add once per number
            }
        }
    }

    console.log("Digits that are repeated twice: ", repeatedDigits);
}

// Call the function
findRepeatedDigits();
