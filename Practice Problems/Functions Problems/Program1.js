// 1. Program to Convert Between Fahrenheit and Celsius Based on User Selection

// Function to convert temperature based on user selection
function temperatureConversion(degree, scale) {
    switch (scale) {
        case 'C':
            if (degree < 0 || degree > 100) {
                console.log("Please enter a temperature between 0°C and 100°C.");
            } else {
                const degF = (degree * 9/5) + 32;
                console.log(`${degree}°C is equal to ${degF.toFixed(2)}°F`);
            }
            break;
        case 'F':
            if (degree < 32 || degree > 212) {
                console.log("Please enter a temperature between 32°F and 212°F.");
            } else {
                const degC = (degree - 32) * 5/9;
                console.log(`${degree}°F is equal to ${degC.toFixed(2)}°C`);
            }
            break;
        default:
            console.log("Invalid scale. Please use 'C' for Celsius or 'F' for Fahrenheit.");
    }
}

// Example usage
const degree = parseFloat(process.argv[2]); // Temperature value from command line
const scale = process.argv[3]; // Scale ('C' or 'F') from command line
temperatureConversion(degree, scale);
