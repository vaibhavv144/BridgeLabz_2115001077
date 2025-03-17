// 4. Program for Unit Conversion of Different Length Units

// Function to convert between different length units
function unitConversion(value, fromUnit, toUnit) {
    let result;

    switch (fromUnit) {
        case 'Feet':
            if (toUnit === 'Inch') {
                result = value * 12; // Feet to Inch
            } else if (toUnit === 'Meter') {
                result = value * 0.3048; // Feet to Meter
            }
            break;
        case 'Inch':
            if (toUnit === 'Feet') {
                result = value / 12; // Inch to Feet
            }
            break;
        case 'Meter':
            if (toUnit === 'Feet') {
                result = value / 0.3048; // Meter to Feet
            }
            break;
        default:
            return "Invalid unit conversion";
    }

    return result !== undefined ? result : "Invalid conversion";
}

// Example usage
const value = parseFloat(process.argv[2]); // Value to convert from command line
const fromUnit = process.argv[3]; // From unit from command line
const toUnit = process.argv[4]; // To unit from command line
console.log(`${value} ${fromUnit} is equal to ${unitConversion(value, fromUnit, toUnit)} ${toUnit}`);
