
/*  
    Prototype - Defines the function (type, name and parameters)
    Definition - It contains the code block
    Function Call - Makes the function execute
    DRY - Don't Repeat Yourself
 */


// Void Functions - Completes a task and moves along
void PrintName()
{
    Console.WriteLine("Sahand");
}
PrintName();


void Addition(int num1, int num2)
{
    Console.WriteLine($"The Sum of {num1} and {num2} is {num1 + num2}");
}
Console.Write("Enter number one: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number two: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Addition(number1, number2);


// Value Returning Functions - Completes a task and returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }
    if (largest < num3)
    {
        largest = num3;
    }
    
    return largest;
}
Console.Write("Enter number three: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");
