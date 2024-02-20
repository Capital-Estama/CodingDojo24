//Problem 1

console.log("Why did the code produce that output?\n If applicable, how would you get that index value that did not output?")

const cars = ['Tesla', 'Mercedes', 'Honda']
const [randomCar] = cars
const [ , otherRandomCar] = cars
//Predict the output 
// Tesla , Mercedes 
console.log(randomCar, otherRandomCar)
const [,,lastRandoCar] = cars 
console.log(lastRandoCar)

// Problem 2
console.log("why did that code produce that output\n If applicable, what would you need to do to solve any potential problems")

const employee = {
    employeeName: 'Elon',
    age: 47,
    company: 'Tesla'
}
const { employeeName: otherName} = employee;
// Predict the output
console.log(otherName);
//console.log(employeeName);


//Problem 3

console.log("Why did the code produce that output?\n If applicable, how would you alter this code without changing either console.log");

const person = { 
    name: 'Phil Smith',
    age: 47,
    height: '6 feet'
}
const password = '12345';
const { password: hashedPassword } = person;
// Predict the output
console.log(password);
//console.log(hashedPassword);

const numbers = [8, 2, 3, 5, 6, 1, 67, 12, 2];
const [,first] = numbers;
const [,,,second] = numbers;
const [,,,,,,,,third] = numbers;
const [,,,,fourth] = numbers;
//Predict the output
console.log(first === second);
console.log(first === third);
console.log(fourth);

// Problem 5
// Why did the code produce that output? Console.log the last value in the secondKey property's array.

const lastTest = {
    key: 'value',
    secondKey: [1, 5, 1, 8, 3, 3]
}
const { key } = lastTest;
const { secondKey } = lastTest;
const [ ,willThisWork] = secondKey;

const {secondKey: [,,,,,lastlast]} = lastTest;
console.log(lastlast);

// Problem 6
// First, how many scopes does the following code block contain? Define each scope and guess what the output will be.

var beatles = ['Paul', 'George', 'John', 'Ringo'];
function printNames(names) {
    function actuallyPrintingNames() {
        for (var index = 0; index < names.length; index++) {
            var name = names[index];
            console.log(name + ' was found at index ' + index);
        }
        console.log('name and index after loop is ' + name + ':' + index);
    }
    actuallyPrintingNames();
}
printNames(beatles);

// Problem 7
// Why did the code produce that output?

function actuallyPrintingNames() {
    for (let index = 0; index < names.length; index++) {
        let name = names[index];
        console.log(name + ' was found at index ' + index);
    }
    console.log('name and index after loop is ' + name + ':' + index);
} 

// Problem 8
// Why did the code produce that output? Explain the output, including any possible errors and why they occurred. If there are no errors, explain the justification for each keyword used to declare variables.
console.log("-----------------------------------------------");
//const beatles = ['Paul', 'George', 'John', 'Ringo'];
function printNames(names) {
    function actuallyPrintingNames() {
        for (let index = 0; index < names.length; index++) {
            const name = names[index];
            console.log(name + ' was found at index ' + index);
        }
    }
    actuallyPrintingNames();
}
printNames(beatles);