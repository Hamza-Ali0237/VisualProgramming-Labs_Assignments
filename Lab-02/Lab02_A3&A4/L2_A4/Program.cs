using System;

class Program
{
    static void areaCircle()
    {
        Console.WriteLine("I don't know the area of the circle");
    }

    static void areaRectangle()
    {
        Console.WriteLine("I don't know the area of the rectangle");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of a shape (Circle, Rectangle) : ");

        string shapeName = Console.ReadLine();

        if(shapeName == "circle")
        {
            areaCircle();
        } else if(shapeName == "rectangle")
        {
            areaRectangle();
        }
    }
}