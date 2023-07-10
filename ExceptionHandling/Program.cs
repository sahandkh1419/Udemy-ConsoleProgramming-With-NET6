
/*  
    try - a try block attempts to complete a task or operation
    catch - catch any fatal error or exception that may occur while trying the operation
    finally - whether the try or the catch was successful, do this
    throw - end program execution with the error
 */

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal Operation: {ex.Message}");
}
catch (Exception ex)
{
	throw ex;
}
finally
{
    Console.WriteLine("This is the end of the program.");
}
