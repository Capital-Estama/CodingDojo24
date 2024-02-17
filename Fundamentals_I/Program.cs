using System.Diagnostics;

// Console style setup
Console.Title = "Fundamentals I";
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkGray;

// Created stop watch object to test excution time 
Stopwatch stopwatch = Stopwatch.StartNew();


// Prompt 1: Create a loop that prints all values from 1-255.
Console.WriteLine("Prompt 1: Create a loop that prints all values from 1-255.");
int tenCount = 0;
for (int i = 1; i <= 255; i++) {
    Console.Write(i + ",");
    tenCount++;
    if (tenCount == 10) {
        Console.WriteLine();
        tenCount = 0;
    }
}
// Stop and Output Total ElapsedMilliseconds 
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
// Timer Restarted 
stopwatch.Restart();

// While loop Alt
Console.WriteLine(" While loop Alt");
int j = 1;
while (j <= 255) {
    if (j % 10 == 0) {
        Console.WriteLine("\n");
    }
    Console.Write(j + ",");
    j++;
}
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();

// Console style setup
Console.Title = "Fundamentals I";
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkCyan;
// Prompt 2: Create a new loop that generates 5 random numbers between 10 and 20.


// Prompt 3: Modify the previous loop to add the random values together and print the sum after the loop finishes.

// Prompt 4: Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

// Prompt 5: Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

// Prompt 6: Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.

// Prompt 7 (Optional): If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!


Console.ResetColor();

// Output Total ElapsedMilliseconds Function
static void ConsoleExcutionTime(Stopwatch stopwatch)
{
    Console.WriteLine($"\nExcution Time: {stopwatch.Elapsed.TotalMilliseconds}ms");
}