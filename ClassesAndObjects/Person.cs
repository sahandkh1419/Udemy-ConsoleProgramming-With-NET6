
public class Person
{   
    // we call them Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // we call them Fields when private
    private double _salary { get; set; }
    public void setSalary(double salary)  // method
    {
        _salary = salary;
    }
    public double getSalary()  // method
    {
        return _salary;
    }

    public string getFullName()  // method
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string MiddleName)  // method overloading
    {

        return $"{FirstName} {MiddleName} {LastName}";
    }
}
