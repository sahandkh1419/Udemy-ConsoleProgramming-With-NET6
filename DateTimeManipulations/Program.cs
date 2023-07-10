using System.Globalization;

// Empty DateTime
DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1999, 9, 20);
Console.WriteLine("My DoB is: " + dateOfBirth);
Console.WriteLine("My DoB Day of Week: " + dateOfBirth.DayOfWeek);
Console.WriteLine("My DoB Day of Year: " + dateOfBirth.DayOfYear);
Console.WriteLine("My DoB Time of Day: " + dateOfBirth.TimeOfDay);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now Is: " + now);

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + dateFromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only of my DoB is: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnlyOfNow = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only of now is: " + timeOnlyOfNow);