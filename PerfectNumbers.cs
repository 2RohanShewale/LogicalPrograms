namespace LogicalPrograms
{
    internal class PerfectNumbers
    {
        public static void Perfect() 
        {
            System.Console.WriteLine("*****Perfect Number*****");
            System.Console.WriteLine("This program will print perfect number till n");
            System.Console.Write("INPUT(n): ");
            int max = Convert.ToInt32(System.Console.ReadLine());
            
            for (int i = 1; i <= max; i++)
            {   
                int sum = 0;
                for (int j = 1; j <= (i/2); j++)
                {
                    
                    if(i%j == 0)
                    {
                        sum+= j;
                    }
                }
                if (sum == i) { System.Console.Write(i + ","); }
            }
        }

    }
}
