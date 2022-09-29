using System;


namespace L1_A3 {
	class Program {
		static void Main(string[] args) {
			if(args[0] == "+") {
				Console.WriteLine(int.Parse(args[1]) + int.Parse(args[2]));
			} else if(args[0] == "-") {
				Console.WriteLine(int.Parse(args[1]) - int.Parse(args[2]));
			} else if(args[0] == "*") {
				Console.WriteLine(int.Parse(args[1]) * int.Parse(args[2]));
			} else if(args[0] == "/") {
				Console.WriteLine(int.Parse(args[1]) / int.Parse(args[2]));
			} else {
				Console.WriteLine("Operator Not Recognized");
			}		
	
		}

	}
}