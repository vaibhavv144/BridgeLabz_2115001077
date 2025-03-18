function generateBirthMonths() {
    const birthMonths = new Map();
    const months = [
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    ];

    // Generate birth months for 50 individuals
    for (let i = 1; i <= 50; i++) {
        const monthIndex = Math.floor(Math.random() * 12); // Random month index (0-11)
        const month = months[monthIndex];

        if (!birthMonths.has(month)) {
            birthMonths.set(month, []);
        }
        birthMonths.get(month).push(`Individual ${i}`);
    }

    // Print individuals grouped by birth month
    for (const [month, individuals] of birthMonths) {
        console.log(`${month}: ${individuals.join(', ')}`);
    }
}

// Call the function
generateBirthMonths();

