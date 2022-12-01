using System;
using System.Runtime.InteropServices;
namespace ConsoleApp3
{
    class Program
    {
     
        public const string CppFunctionDll = @"C:\\Users\\assai\\source\\repos\\NewRepo6\\Debug\\Dll1.dll";

        [DllImport(CppFunctionDll)]
        public static extern double sumTwo(double var_x, double var_y);

        static void Main()
        {
            double var_x = 10;
            double var_y = 5;

            double result = sumTwo(var_x, var_y);
            Console.WriteLine(result);
        }
      
    }
}

