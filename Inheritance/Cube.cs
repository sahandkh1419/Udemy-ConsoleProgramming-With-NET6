
// Inheritance allows to define one source of common properties and then reuse that source across multiple places
// whatever is inheriting is called a derived class (example here: Cube) and whatever is being inherited is called the base class (example here: Shape)


// To create Constructor we write ctor and press tab twice
// Constructors: 1- are public 2- they have the same name as the class 3- they can take parameters
public class Cube: Shape, IShape
{
    public Cube(int length, int width, int height)  // constructor
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }
}
