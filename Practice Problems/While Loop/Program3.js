// 3. Program to Extend the Flip Coin Problem Until Either Heads or Tails Wins 11 Times

// Function to simulate coin flip until one side wins 11 times
function flipCoin() {
    let headsCount = 0;
    let tailsCount = 0;

    while (headsCount < 11 && tailsCount < 11) {
        const flip = Math.random() < 0.5 ? "Heads" : "Tails";
        console.log("Coin Flip Result: " + flip);

        if (flip === "Heads") {
            headsCount++;
        } else {
            tailsCount++;
        }
    }

    console.log(`Heads won: ${headsCount}, Tails won: ${tailsCount}`);
}

// Call the function
flipCoin();
