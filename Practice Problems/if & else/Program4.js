// 4. Program to Simulate a Coin Flip

// Function to simulate a coin flip
function coinFlip() {
    // Generate a random number (0 or 1)
    let flip = Math.random() < 0.5 ? "Heads" : "Tails";
    console.log("Coin Flip Result: " + flip);
}

coinFlip();
