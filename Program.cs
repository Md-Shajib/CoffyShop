using System;
class Program
{
    static void Main()
    {
        Start:
        Console.WriteLine("Enter your choice: \n\t1.Coffee\n\t2.Tea\n\t3.Ice-Cream\n\t4.Drinks\n");
        int UserChoice = int.Parse(Console.ReadLine());

        int totalCost = 0;
        switch (UserChoice)
        {
            case 1:
                Console.WriteLine("\n\t1.Cold Coffee\n\t2.Hot Coffee");
                int userSubChoice = int.Parse(Console.ReadLine());
                if(userSubChoice == 1)
                {
                    totalCost += 50;
                    Console.WriteLine($"Thank You for shopping. \nYou select Cold Coffee and the price is: {totalCost}\n");
                }else if(userSubChoice == 2)
                {
                    totalCost += 30;
                    Console.WriteLine($"Thank You for shopping. \nYou select Hot Coffee and the price is: {totalCost}\n");
                }else
                {
                    Console.WriteLine("Please enter the valid choice...\n");
                    goto case 1;
                }
                break;
            case 2:
                Console.WriteLine("\n\t1.Red Tea\n\t2.Green Tea\n\t3.Milk Tea\n");
                int userSubChoice2 = int.Parse(Console.ReadLine());
                if (userSubChoice2 == 1)
                {
                    totalCost += 10;
                    Console.WriteLine($"Thank You for shopping. \nYou select Red Tea and the price is: {totalCost}\n");
                }
                else if (userSubChoice2 == 2)
                {
                    totalCost += 20;
                    Console.WriteLine($"Thank You for shopping. \nYou select Green Tea and the price is: {totalCost}\n");
                }
                else if(userSubChoice2 == 3)
                {
                    totalCost += 20;
                    Console.WriteLine($"Thank You for shopping. \nYou select Milk Tea and the price is: {totalCost}\n");
                }
                else
                {
                    Console.WriteLine("Please enter the valid choice...\n");
                    goto case 2;
                }
                break;
            case 3:
                totalCost += 50;
                Console.WriteLine($"Thank You for shopping. \nYou select Ice-Cream and the price is: {totalCost}\n");
                break;
            case 4:
                totalCost += 100;
                Console.WriteLine($"Thank You for shopping. \nYou select Drinks and the price is: {totalCost}\n");
                break;

        }
        Restart:
        Console.WriteLine("Do You want to shop more? Yes or No\n");
        string Choice = Console.ReadLine().ToUpper();
        if( Choice == "YES")
        {
            goto Start;
        }else if( Choice == "NO")
        {
            Console.WriteLine("Thank You Very Much");
        }
        else
        {
            Console.WriteLine("Please enter the valid choice\n");
            goto Restart;
        }
    }
}