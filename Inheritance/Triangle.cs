
// Class can have two or more constructors
public class Triangle : Shape, IShape
{
    public Triangle()  // default constructor
    {
            
    }
    public Triangle(int hypotenuese)  // defined constructor
    {
        Hypotenuese = hypotenuese;
    }
    public Triangle(int length, int height, int hypotenuese)  // defined constructor
    {
        Length = length;
        Height = height;
        Hypotenuese = hypotenuese;
    }

    public double Hypotenuese { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}
