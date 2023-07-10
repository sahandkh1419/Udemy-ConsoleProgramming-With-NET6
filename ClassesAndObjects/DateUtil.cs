
// if the class is static, then the entire everything else in the class must be static... but inside a regular class we can have static methods without having to make the class static!
internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }

    public static int YearOfBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return dateOfBirth.Year;
    }

    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return DateTime.Now.Year - dateOfBirth.Year;
    }
}
