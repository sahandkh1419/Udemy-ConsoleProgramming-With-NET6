
// Object Oriented Programming Languages allow us to create our own data types and we do that through the definition of Class!

/*
    Class is like a blueprint of what the object is going to be 
    In defining the class we have to give its properties.
    Properties refer to the knowns of the objects. In case of Person class: name, age, address and etc are properties
    In defining a propery we give it an access modifier which there are different ones: 1- public(anybody can access) 2- internal(only other files inside the same project can access) 3- private
    { get; set; } means once i'm interacting with a Person, i have the leverage to get what their Name is or set what their Name is! 
    
    we don't want to define a class inside of another class and each class should be in its own file.
    Single Responsibility Principle: let each unit as far as practicle have only one responsibility... so Program.cs file should not have the responsibility of defining our Person class
    
    methods represent what can object do... A person can walk, can eat and etc
 */

Person p1 = new Person();
Person p2 = new();

Console.Write("Enter First Name: ");
p1.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
p1.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
p1.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
p1.setSalary(salary);

string middleName = string.Empty;
Console.Write("If You Have, Enter Middle Name: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full Name is: " + p1.getFullName());
}
else
{
    Console.WriteLine("Full Name is: " + p1.getFullName(middleName));
}

//Console.WriteLine("First Name is: " + p1.FirstName);
//Console.WriteLine("Last Name is: " + p1.LastName);  // we can use method .getFullName()
Console.WriteLine("Age is: " + p1.Age);
Console.WriteLine("Salary is: " +  p1.getSalary());


/*  
    Encapsulation: when user is interacting with the object of type person, they can interact with certain things but they don't necessarily understand how it works
    Aggregation: inside of one complex class we've aggregated a number of properties and operations. 
 */


// A static class can not be instantiated meaning that we can't create an object of that class... for example Console is a static class 
// A static class is usually used as like an utility class
Console.WriteLine("Year of Birth is: " + DateUtil.YearOfBirth(p1.Age));
