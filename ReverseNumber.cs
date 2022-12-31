namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void Display()
        {
            Console.WriteLine("*****Reverse a Number*****");
            Console.Write("Input: ");
            int n = Convert.ToInt32(Console.ReadLine());//545
            int rem;
            int ans = 0;
            while (n!=0)
            {
                rem = n % 10;//5//5
                ans = (ans * 10) + rem;//5//54
                n /= 10;//54//
            }
            Console.WriteLine(ans);
        }
    }
}
