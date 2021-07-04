// This is a comment

/*
* This is a Block comment
*/

// Print in Console
Console.WriteLine("Hello World!");

// With Var
string aFriend = "Bill";
// Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");

// String Func
Console.WriteLine($"The name {aFriend} has {aFriend.Length} letters.");

// Remove Whitespace from ...
string spacey = "    Hei paa deg    ";
spacey.TrimStart();
spacey.TrimEnd();
spacey.Trim(); // Both Ends

// Replace the first word with the secoud one
string myName = aFriend;
myName.Replace("Bill", "Akisan");

// Upper and Lowercase
myName.ToUpper();
myName.ToLower();

// Check if String contains and return bool - True / False
// Case Sensitive - Upper G is not Lower g.
var res = myName.Contains("isa");

// Check if string starts / ends with following
myName.StartsWith("Aki");
myName.EndsWith("san");

// Ints
// Multiplication and division take precedence over addition and subtraction.
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

// Force a different order of operation by adding parentheses
d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}"); // Normal Divition to int not double
Console.WriteLine($"remainder: {e}"); // Modula

// Int min / max values before overflow
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// Double all same but decimal
double a = 5;
double b = 5.0;
Console.WriteLine((a+b) - 0.1); // If number if perfectly round it does not print XX.0


// The decimal type has a smaller range but greater precision than double.
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

// M indicates is a decimal
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

// If Statements
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

// Indentation isn't significant

int a = 5;
int b = 3;
if (a + b > 10) Console.WriteLine("The answer is greater than 10");
else Console.WriteLine("The answer is not greater than 10");

// When you have more than one line in the block
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

// Logic && - AND || - OR

// While Loop
// While loop tests the condition before executing
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}

// The do ... while loop executes the code first, and then checks the condition
int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);

// For Loop
for(int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

// Prints a - j
for (char column = 'a'; column < 'k'; column++)
{
  Console.WriteLine($"The column is {column}");
}

// For each
var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Other list functions

// .Add("Maria");
// .Remove("Ana");
// names[0] == "<name>"
// names.Count
// names.IndexOf("Felipe"); Returns index or -1 (If not found)
// names.Sort();
