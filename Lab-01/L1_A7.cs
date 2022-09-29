using System;

class L1_A7 {

	static void Main(string[] args) {
		int num1 = 15;
		int num2 = 5;

		DivideWithoutOperator(num1, num2);
	}
	
	static void DivideWithoutOperator(int dividend, int divisor) {
		Console.Write("Division = ");
		double division = dividend / divisor;
		Console.Write(division);
	}
}