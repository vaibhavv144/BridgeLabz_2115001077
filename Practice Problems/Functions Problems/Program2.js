// 2. Program to Check if Two Numbers are Palindromes

// Function to check if a number is a palindrome
function isPalindrome(num) {
    const strNum = num.toString();
    return strNum === strNum.split('').reverse().join('');
}

// Function to check if two numbers are palindromes
function checkTwoNumbersPalindrome(num1, num2) {
    const isNum1Palindrome = isPalindrome(num1);
    const isNum2Palindrome = isPalindrome(num2);
    
    console.log(`${num1} is ${isNum1Palindrome ? '' : 'not '}a palindrome.`);
    console.log(`${num2} is ${isNum2Palindrome ? '' : 'not '}a palindrome.`);
}

// Example usage
const num1 = parseInt(process.argv[2]); // First number from command line
const num2 = parseInt(process.argv[3]); // Second number from command line
checkTwoNumbersPalindrome(num1, num2);
