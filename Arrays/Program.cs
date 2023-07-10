
// Declare Fixed Size Array
int[] grades = new int[5];  // 5 space addresses in memory - 0,1,2,3,4

// Add values to Fixed Size Array
//grades[0] = 82;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 62;

//grades = new int[] { 82, 25, 38, 45, 62 };  // oneliner of 5 above

// comment 6 above and check below
Console.WriteLine("***Enter All Grades***");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Enter Grade number {i+1}: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());  
}

// Print values in Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Grade number {i+1} is: {grades[i]}");
}



// Declare Variable Sized Array
string[] studentNames = new string[] { "Sahand", "Amir", "Ali" };
// Adding and printing are the same as above and we use for loop
