using System;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins: ");
            string convert = Console.ReadLine();

            double convert2 = Convert.ToDouble(convert);
            Console.WriteLine($"{convert} cents is equal to... ");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(convert2 / 10);
            double leftOver = Math.Floor(convert2 % 10);

            double silverCoins = Math.Floor(leftOver / silverValue);

            leftOver = Math.Floor(leftOver % silverValue);


            Console.WriteLine($"Gold coins: {goldCoins} Silver coins:  {silverCoins} ");
        }
    }
}
