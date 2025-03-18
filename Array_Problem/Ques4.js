function findTriplets(arr) {
    const triplets = [];
    const n = arr.length;

    for (let i = 0; i < n - 2; i++) {
        for (let j = i + 1; j < n - 1; j++) {
            for (let k = j + 1; k < n; k++) {
                if (arr[i] + arr[j] + arr[k] === 0) {
                    triplets.push([arr[i], arr[j], arr[k]]);
                }
            }
        }
    }

    console.log("Triplets that sum to zero: ", triplets);
}

// Example usage
const numbers = [-1, 0, 1, 2, -2, -3, 3]; // Sample array
findTriplets(numbers);
