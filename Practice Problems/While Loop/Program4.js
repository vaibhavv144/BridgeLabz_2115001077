// 4. Program for a Gambler Who Starts with Rs 100 and Places Re 1 Bet

// Function to simulate gambler's betting game
function gamblerGame() {
    let balance = 100; // Starting balance
    let betsMade = 0;
    let wins = 0;

    while (balance > 0 && balance < 200) {
        betsMade++;
        const betOutcome = Math.random() < 0.5; // 50% chance to win

        if (betOutcome) {
            balance++; // Win Rs 1
            wins++;
        } else {
            balance--; // Lose Rs 1
        }
    }

    if (balance === 0) {
        console.log("Gambler went broke after " + betsMade + " bets.");
    } else {
        console.log("Gambler reached the goal of Rs 200 after " + betsMade + " bets.");
    }

    console.log(`Total Wins: ${wins}, Total Bets Made: ${betsMade}`);
}

// Call the function
gamblerGame();

