using System;

namespace TipCalculatorCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TipCalculator");
            Console.Write("Bill is -> ");
            float bill = float.Parse(Console.ReadLine());
            Console.WriteLine(bill);

            Console.WriteLine("How much tip you want to give 10 15 20 or enter other amount");
            float tip = float.Parse(Console.ReadLine());
            //Console.WriteLine(tip);
            float tipRatio = tip / 100;
            //Console.WriteLine(tipRatio);
            float TotalBill = tip / 100 * bill + bill;
            Console.WriteLine(TotalBill);
            Console.WriteLine("How much people you are");
            float people = float.Parse(Console.ReadLine());
            //Console.WriteLine(people);
            float TotalBillPerUser = (float)Math.Round(TotalBill/people);
            //Console.WriteLine(TotalBillPerUser);
            Console.Write("Your Total Bill per user is -> ");
            Console.WriteLine(TotalBillPerUser);
        }
    }
}
