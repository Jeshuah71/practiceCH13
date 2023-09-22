
// Practice code 
Console.WriteLine("Hello World");
CountToTen();
CountToTen();
void CountToTen()
{
    for (int current = 1; current <= 10; current++)
    Console.WriteLine(current);
}
// Another example of methods 
Console.WriteLine("Insert a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
CountToTwenty();
void CountToTwenty()
{
 for (int num1  = 1; num1 <= 20; num1++)
 Console.WriteLine(num1);
}

string text = Console.ReadLine();
void DisplayText()
{
    Console.WriteLine(text);
}
// passing data to a method // this is just an example that was at the book
void Count(int numberToCountTo)
{
 for (int current = 1; current <= numberToCountTo; current++)
 Console.WriteLine(current);
}
// Multiple parameters

void CountBetween(int start, int end) 
{
 for (int current = start; current <= end; current++)
 Console.WriteLine(current);
}

// Challenge 13 (1)
int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}
