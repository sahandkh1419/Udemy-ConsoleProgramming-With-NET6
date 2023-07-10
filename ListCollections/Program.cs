
// Declare a list
List<string> names = new List<string>();
string name = string.Empty;

// Adding values to list
names.Add("Ali");

Console.WriteLine("***Enter Names***");
// while(name != "-1")  =:  while(name.Equals("-1") == false) =: while(!name.Equals("-1"))
while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if(!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && !name.Equals("-1"))
    {
        Console.WriteLine($"{name} was added successfully");
        names.Add(name);
    }
}


// Print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}
