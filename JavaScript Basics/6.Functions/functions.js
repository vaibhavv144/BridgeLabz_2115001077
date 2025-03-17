// Functions are reusable blocks of code.

//1. Function Declaration (Named Function)
// (A function declaration defines a function with a name and can be called before its definition (due to hoisting))

// Function Declaration
function greet(name) {
    console.log("Hello, " + name + "!");
}

// Calling the function
greet("Shivam");
greet("Vaibhav");

//2. Function Expression (Anonymous Function)
// (A function expression assigns a function to a variable. It cannot be called before its definition.)

// Function Expression
let greet1 = function(name) {
    console.log("Hello, " + name + "!");
};

// Calling the function
greet1("Vaibhav");
greet1("Siddhant");


//3. Arrow Function (ES6)
// (An arrow function is a shorter way to write functions. It removes the function keyword and uses =>.)

// Arrow Function
const greet2 = (name) => {
    console.log(`Hello, ${name}!`);
};

// Calling the function
greet2("Shivam");
greet2("Sudhanshu");

// 4. Function with Return Value
// (A function can return a value instead of printing it.)

// Function with return
function add(a, b) {
    return a + b;
}

// Calling the function
let sum = add(10, 5);
console.log("Sum:", sum);


// 5. Function with Default Parameters
// (If no argument is passed, the default value is used.)

// Function with default parameter
function greet3(name = "Guest") {
    console.log("Hello, " + name + "!");
}

// Calling the function
greet3();       // Uses default value "Guest"
greet3("Shivam"); // Uses "Shivam"




