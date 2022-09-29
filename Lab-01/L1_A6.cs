using System;

class Program {
	static void Main(string[] args) {
			
		string num1; 
		string num2;
		string op;

		Console.Write("Enter The Operator : ");
		op = Console.ReadLine();

		Console.Write("Enter 1st Number : ");
		num1 = Console.ReadLine();

		Console.Write("Enter 2nd Number : ");
		num2 = Console.ReadLine();

		if(op == "+") {
			Console.WriteLine(int.Parse(num1) + int.Parse(num2));
		} else if(op == "-") {
			Console.WriteLine(int.Parse(num1) - int.Parse(num2));
		} else if(op == "*") {
			Console.WriteLine(int.Parse(num1) * int.Parse(num2));
		} else if(op == "/") {
			Console.WriteLine(int.Parse(num1) / int.Parse(num2));
		} else {
			Console.WriteLine("op Not Recognized");
		}		
	
	}

}