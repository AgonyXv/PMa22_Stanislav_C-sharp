using System;

namespace task3
{
    public delegate double CalcDelegate(double num1, double num2, char op);

    public class CalcProgram
    {
        public static double Calc(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        return Int32.MaxValue;
                    }
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        public CalcDelegate FuncCalc = new CalcDelegate(Calc);
    }

    // class Program
    // {
    //     static void Main()
    //     {
    //         CalcProgram calcProgram = new CalcProgram();

    //         double result = calcProgram.FuncCalc(5, 3, '+');
    //         Console.WriteLine($"Result: {result}");

    //         result = calcProgram.FuncCalc(4, 5, '-');
    //         Console.WriteLine($"Result: {result}");

    //         result = calcProgram.FuncCalc(2, 0, '*');
    //         Console.WriteLine($"Result: {result}");

    //         result = calcProgram.FuncCalc(12, 6, '/');
    //         Console.WriteLine($"Result: {result}");
    //     }
    // }
}