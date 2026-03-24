using System;

class Program
{
    static void Main(string[] args)
    {
        Square squareko = new Square("Blue", 5);
        // Console.WriteLine("squareko:");
        // Console.WriteLine(squareko.GetColor());
        // Console.WriteLine(squareko.GetArea());

        Rectangle rectangleko = new Rectangle("Green", 5,7);
        // Console.WriteLine("\nrectangleko:");
        // Console.WriteLine(rectangleko.GetColor());
        // Console.WriteLine(rectangleko.GetArea());

        Circle circleko = new Circle("Red", 5);
        // Console.WriteLine("\ncircleko:");
        // Console.WriteLine(circleko.GetColor());
        // Console.WriteLine(circleko.GetArea());

        List<Shape> listofshapes = new List<Shape>();
        listofshapes.Add(squareko);
        listofshapes.Add(rectangleko);
        listofshapes.Add(circleko);

        foreach (Shape shape in listofshapes)
        {
           Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }






    }
}