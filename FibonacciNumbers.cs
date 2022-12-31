using System.IO.Pipes;

namespace LogicalPrograms
{
    internal class FibonacciNumbers
    {
        public static void Fibonacchi()
        {
            System.Console.WriteLine("*****Fibonacci Numbers*****");
            System.Console.WriteLine("Find nth Fibonacci Number");
            System.Console.Write("Input: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            int a = 0; int b = 1; int c ;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            System.Console.WriteLine(b);
            System.Console.WriteLine("Output: " + b);
        }
    }
}
