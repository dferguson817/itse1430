using System;

public class Program
{
    public static void Main ()
    {
        double USD = 1.40;
        double UpTo300 = 0.035;
        double Over300 = 0.03;
        double Over750 = 0.025;

        double sDiscount;
        double tFee;
        double tCost;
        double sCost;
        double discount = 0.5;

        double top1 = 1.25;
        double num1;
        double top2 = 2.25;
        double num2;
        double Large = 15.00;
        double Medium = 10.00;
        double Small = 7.50;

        Console.WriteLine("Welcome to Ferguson pizza Shop");

        Console.WriteLine("Hello how can i help you today :");

        Console.WriteLine("\nSelect your Pizza ");

        Console.WriteLine("1. Small ");
        Console.WriteLine("2. Medium ");
        Console.WriteLine("3. Large ");
        string Pizza = Console.ReadLine();



        if (Pizza == "Small" || Pizza == "1")
        {
            Console.Write("Enter number of small pizzas :");
            int quanity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of small pizzas : ");
            double pizza = double.Parse(Console.ReadLine());
            double usdCurr = quanity * Small;
            Console.WriteLine("Cost :  "+ usdCurr);

            Console.WriteLine("topping 1");
            num1 = top1 + usdCurr;
            Console.WriteLine("Pizza cost : 1.25 " + num1);

            Console.WriteLine("topping 2");
            num2 = top2 + usdCurr;
            Console.WriteLine("Pizza cost : 2.25" + num2);

            if (num1> 20)

            {
                sDiscount = num1 * discount;
                Console.WriteLine("discount $" + sDiscount);
                tCost = num1 - sDiscount;
                Console.WriteLine("Total cost $ " + tCost);
            }

        }

        if (Pizza == "Medium" || Pizza == "2")
        {
            Console.Write("Enter number of medium pizzas :");
            int quanity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of medium pizzas : ");
            double pizza = double.Parse(Console.ReadLine());
            double usdCurr = quanity * Medium;
            Console.WriteLine("Cost :  "+ usdCurr);

            Console.WriteLine("topping 1");
            num1 = top1 + usdCurr;
            Console.WriteLine("Pizza cost : 1.25 " + num1);

            Console.WriteLine("topping 2");
            num2 = top2 + usdCurr;
            Console.WriteLine("Pizza cost : 2.25" + num2);

            if (num1> 20)

            {
                sDiscount = num1 * discount;
                Console.WriteLine("discount $" + sDiscount);
                tCost = num1 - sDiscount;
                Console.WriteLine("Total cost $ " + tCost);
            }

        }

        if (Pizza == "large" || Pizza == "3")
        {
            Console.Write("Enter number of large pizzas :");
            int quanity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of large pizzas : ");
            double pizza = double.Parse(Console.ReadLine());
            double usdCurr = quanity * Large;
            Console.WriteLine("Cost :  "+ usdCurr);

            Console.WriteLine("topping 1");
            num1 = top1 + usdCurr;
            Console.WriteLine("Pizza cost : 1.25 " + num1);

            Console.WriteLine("topping 2");
            num2 = top2 + usdCurr;
            Console.WriteLine("Pizza cost : 2.25" + num2);


            if (num1> 20)

            {
                sDiscount = num1 * discount;
                Console.WriteLine("discount $ " + sDiscount);
                tCost = num1 - sDiscount;
                Console.WriteLine("Total cost $ " + tCost);
            }

        }



        Console.ReadLine();
    }
}