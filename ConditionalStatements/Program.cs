
Console.Write("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, <, >, >=, <=, !=)
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else
{
    Console.WriteLine("You have the same number of apples and oranges");
}


Console.Write("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch (grade)
{
    case int n when (n >= 0) && (n <= 59):
        Console.WriteLine("You Failed!");
        break;
    case int n when (n >= 60) && (n <= 100):  // between 60 and 100
        Console.WriteLine("You Passed!");
        break;
    case 101:
        Console.WriteLine("Single Case Example!");
        break;
    default:
        Console.WriteLine("Invalid Grade!");
        break;
}


// Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);
