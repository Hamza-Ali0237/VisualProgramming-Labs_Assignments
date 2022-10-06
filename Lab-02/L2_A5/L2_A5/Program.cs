using L2_A5;
using System;

class Program
{
    static void Main(string[] args)
    {
        MathClass obj = new MathClass();
        Console.WriteLine("Enter Operator : ");
        string op = Console.ReadLine();
        obj.setOperator(op);

        Console.WriteLine("\nEnter First Value : ");
        obj.setFirstValue(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("\nEnter Second Value : ");
        obj.setSecondValue(Convert.ToInt32(Console.ReadLine()));

        if(obj.getOperator() == "+")
        {
            Console.WriteLine("Addition = " + (obj.getFirstValue() + obj.getSecondValue()));
        } else if (obj.getOperator() == "-")
        {
            Console.WriteLine("Subtraction = " + (obj.getFirstValue() - obj.getSecondValue()));
        } else if (obj.getOperator() == "*")
        {
            Console.WriteLine("Multiplication = " + (obj.getFirstValue() * obj.getSecondValue()));
        }
        else if (obj.getOperator() == "/")
        {
            Console.WriteLine("Subtraction = " + (obj.getFirstValue() / obj.getSecondValue()));
        } 
    }
}