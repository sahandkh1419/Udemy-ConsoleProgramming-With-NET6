
// Consider we forgot to put in getArea method for Rectangle class... to prevent problems like that we use interfaces
// Interface is a scaled down version of a class but it's more like a contract... An Interface can declare properties, methods and etc but can't define them! because the definitions could be different
// We can declare that every derived class that is inheriting from our interface must have a definition for a particular method

Console.Write("Enter Length: ");  // طول
int length  = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Width: ");  // عرض
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height: ");  // ارتفاع
int height = Convert.ToInt32(Console.ReadLine());

// when we don't use consructor in code:
//var cube = new Cube();  // مکعب
//cube.Length = length;
//cube.Width = width;
//cube.Height = height;
// alternative for above is:
//var cube = new Cube() { Length=length, Width=width, Height=height };
// when we use constructor in code:
var cube = new Cube(length, width, height);

//var rectangle = new Rectangle();  // مستطیل
//rectangle.Length = length;
//rectangle.Width = width;
// alternative for above is:
var rectangle = new Rectangle() { Length=length, Width=width};

// when we don't use consructor in code:
//var triangle = new Triangle();  // مثلث
//triangle.Length = length;
//triangle.Height = height;
// alternative for above is (when we use default constructor in code:):
var triangle = new Triangle() { Length=length, Height=height, Hypotenuese=10 };
//  when we use defined constructor in code:
var triangle1 = new Triangle(10);
var triangle2 = new Triangle(length, height, 10);


/* 
    Constructors are default methods that are going to be created in a class that enforce an object to meet some specifications before it can be instantiated
 */


Console.WriteLine("Cube Area Is: " + cube.GetArea());
Console.WriteLine("Cube Volume Is: " + cube.GetVolume());

Console.WriteLine("Triangle Area Is: " + triangle.GetArea());

Console.WriteLine("Rectangle Area Is: " + rectangle.GetArea());
