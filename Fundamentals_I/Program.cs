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
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkCyan;

// Prompt 2: Create a new loop that generates 5 random numbers between 10 and 20.
Console.WriteLine(" Create a new loop that generates 5 random numbers between 10 and 20.\n");
Random rand = new Random();
Func<int> nextNumber = () => rand.Next(10,21);
for (int k = 1;k <=5; k++) {
    Console.WriteLine(nextNumber());
}
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();


Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;
// Prompt 3: Modify the previous loop to add the random values together and print the sum after the loop finishes.

Console.WriteLine("Modify the previous loop to add the random values together and print the sum after the loop finishes.\n");
int randSum = 0;
for (int k = 1;k <=5; k++) {
    int i = nextNumber();
    Console.WriteLine(i);
    randSum += i;
}
Console.WriteLine($"sum after the loop: {randSum}\n");
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();

Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.DarkGreen;
// Prompt 4: Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
Console.WriteLine(" Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.\n\n");
for(int l = 1; l <= 100; l++) {
    if((l % 3 == 0 || l % 5 == 0 ) && !(l % 3 == 0 & l % 5 == 0)) {
        Console.Write(l + ",");
    }
}
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();

// Prompt 5: Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
Console.WriteLine(" Modify the previous loop to print \"Fizz\" for multiples of 3 and \"Buzz\" for multiples of 5.\n\n");
for (int l = 1; l <= 100; l++) {
    if((l % 3 == 0 || l % 5 == 0 ) && !(l % 3 == 0 & l % 5 == 0)) {
        if(l % 3 == 0) {
            Console.Write("Fizz\n");
        }
        else {
            Console.Write("Buzz\n");
        }
        
    }
}
stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();

Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.DarkMagenta;

// Prompt 6: Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
Console.WriteLine(" Modify the previous loop to print \"Fizz\" for multiples of 3 and \"Buzz\" for multiples of 5.\n\n");
for (int l = 1; l <= 100; l++) {
    if (l % 3 == 0 & l % 5 == 0) {
        {
            Console.WriteLine("FizzBuzz");
        }
    }
        else if (l % 3 == 0) {
            Console.Write("Fizz\n");
        }
        else if (l % 5 == 0) {
            Console.Write("Buzz\n");
        }
        
}

stopwatch.Stop();
ConsoleExcutionTime(stopwatch);
stopwatch.Restart();

// Prompt 7 (Optional): If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!


Console.ResetColor();

// Output Total ElapsedMilliseconds Function
static void ConsoleExcutionTime(Stopwatch stopwatch)
{
    Console.WriteLine($"\nExcution Time: {stopwatch.Elapsed.TotalMilliseconds}ms");
}