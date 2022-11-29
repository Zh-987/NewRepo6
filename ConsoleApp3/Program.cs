using System;
using System.Runtime.InteropServices;
namespace ConsoleApp3
{
    class Program
    {
        public const string CppFunctionDll = @"C:\Users\assai\source\repos\ConsoleApp3\Debug\ExampleForItstep.dll";

        [DllImport(CppFunctionDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);
        [DllImport(CppFunctionDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubtractNumbers(int a, int b);
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Num1: ");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                num1 = 10;
            }
            Console.WriteLine("Num2: ");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                num2 = 5;
            }

            int output = AddNumbers(num1, num2);


            Console.WriteLine($"Output: {output}");

            Console.ReadLine();

        }  
        /*  Console.WriteLine("Hello World!");*/
    }
}
