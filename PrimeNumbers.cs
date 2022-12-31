using System.Globalization;

namespace LogicalPrograms
{
    internal class PrimeNumbers
    {
        public static void Display()
        {
            Console.WriteLine("****Prime Numbers*****");
            Console.WriteLine("This program will print prime numbers till n");
            Console.Write("Input (n): ");
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=max; i++)
            {
                if (i == 1) { Console.Write(i + " "); }
                else if (i == 2) { Console.Write(i + " "); }
                else
                {
                    bool b = isPrime(i);
                    if (b) { System.Console.Write(i + " "); }
                }
            }
            
        }

        static bool isPrime(int n)
        {
            if (n%2 == 0) { return false; }
            else
            {   
                int k = 0;
                for (int i = 3; i < n; i+=2)
                {
                    if(n%i == 0)
                    {
                        k += i;
                    }
                }
                if (k == 0) { return true; }
                else { return false; }
            }
        }
    }
}
