// Used to repeat actions.
//for loop

for (let i = 1; i <= 5; i++) {
    console.log("Number:", i);
}


//while loop

let count = 1;
while (count <= 5) {
    console.log("Count:", count);
    count++;
}


//do-while loop

let i = 1;
do {
    console.log("Number:", i);
    i++;
} while (i <= 5);


// for...of Loop (Used for Arrays)

let fruits = ["Apple", "Banana", "Mango"];

for (let fruit of fruits) {
    console.log("Fruit:", fruit);
}

// for...in Loop (Used for Objects)

let person = { name: "Alice", age: 25, city: "New York" };

for (let key in person) {
    console.log(key + ":", person[key]);
}


// Loop with break and continue

for (let i = 1; i <= 5; i++) {
    if (i === 3) break; // Stops when i is 3
    console.log("Number:", i);
}

// Example: Skip 3 using continue
for (let i = 1; i <= 5; i++) {
    if (i === 3) continue; // Skips when i is 3
    console.log("Number:", i);
}

