
string firstName = "Sahand";
string lastName = "Khorsandi";
DateTime date = DateTime.Now;


// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed!");
Console.WriteLine("-----------------------------");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + ", " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);
Console.WriteLine("-----------------------------");

// String length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");
Console.WriteLine("-----------------------------");

// Replace string parts
string newName = firstName.Replace('a', 'i');
Console.WriteLine($"Your new name is {newName}");
Console.WriteLine("-----------------------------");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");
Console.WriteLine("-----------------------------");

// Split String
string[] splitName = fullName.Split(' ');
Console.WriteLine("using for: ");
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}
Console.WriteLine("using foreach: ");
foreach (var item in splitName)
{
    Console.WriteLine(item);
}
Console.WriteLine("-----------------------------");

// Compare Strings
string nullString = null;
string emptyString = "";  // string.Empty;
string whiteSpaceString = " ";
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}
if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}
Console.WriteLine("-----------------------------");

// Convert to String
string convertedString = string.Empty;
convertedString = 123321456.ToString();
Console.WriteLine(convertedString);
