// 3. Program to Check if a Number is Prime and if its Palindrome is Also Prime

// Function to check if a number is prime
    function isPrime(num) {
        if (num <= 1) return false;
        for (let i = 2; i <= Math.sqrt(num); i++) {
            if (num % i === 0) return false;
        }
        return true;
    }

    // Function to get the palindrome of a number
    function getPalindrome(num) {
        return parseInt(num.toString().split('').reverse().join(''));
    }

    // Function to check if a number and its palindrome are prime
    function checkPrimeAndPalindrome(num) {
        const isNumPrime = isPrime(num);
        const palindromeNum = getPalindrome(num);
        const isPalindromePrime = isPrime(palindromeNum);
        
        console.log(`${num} is ${isNumPrime ? '' : 'not '}a prime number.`);
        console.log(`The palindrome of ${num} is ${palindromeNum}.`);
        console.log(`The palindrome ${palindromeNum} is ${isPalindromePrime ? '' : 'not '}a prime number.`);
    }

    // Example usage
    const num = parseInt(process.argv[2]); // Number from command line
    checkPrimeAndPalindrome(num);
