using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {

        public static void GenerateCoupons()
        {
            Console.WriteLine("Lets create Coupon Numbers");
            Console.WriteLine("How many coupon you have to create ? ");
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {

                int randomNum = random.Next(0, 1000000);
                arr[i] = randomNum;
            }
            foreach (int data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}