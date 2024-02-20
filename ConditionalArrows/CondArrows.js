// let canAfford = (itemPrice, accountBalance) =>{
//     return itemPrice > accountBalance ?
//  `Cannot afford! You are $${itemPrice - accountBalance} short`
//  : "Can afford!";
// }

// Problem 1
// Write an arrow function that checks to see if a user is older than 18.
// If they are older than 18, the output should be:

// "You are good to go!"

// If they are not older than 18, the output should be:

// "Sorry! You must be 18 or older!"


// The conditional logic should be written with a ternary operator.
const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Please Enter age (16 - 40): ', (userData) => {

    console.log(`You entered: ${userData}`);
    rl.close();
});
// Problem 2
// Write an arrow function that checks to see if it is currently raining.


// If it is raining, the output should be:

// "Get your rain jacket!"

// If it is not raining, the output should be:

// "No rain on today's forecast!"


// The conditional logic should be written with a ternary operator.

// Problem 3
// Write an arrow function that checks to see if a number is even.


// If it is even, the output should be:

// "That's an even number!"

// If it is not even, the output should be:

// "That's an odd number!"


// The conditional logic should be written with a ternary operator.



// Problem 4
// Write an arrow function that takes in two parameters and checks whether one number is greater than another.


// If the number is greater, the output should be:

// "<<NUMBER HERE>> is more than <<SECOND NUMBER HERE>>!"

// If the number is less than the other number, the output should be:

// "<<NUMBER HERE>> is less than <<SECOND NUMBER HERE>>!"


// The conditional logic should be written with a ternary operator.

// Ninja Challenge!
// To increase the difficulty, try to write each of your solutions as implicit returns with the least amount of characters possible. Look back to the rules of arrow functions and how we can simplify them further.
