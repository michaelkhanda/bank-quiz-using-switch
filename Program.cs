using System;

namespace Bankquizonmethods
{
    class Program
    {
        static double Deposit(double depoamount, double initialbalance)
        {
            double currentbalance = initialbalance + depoamount;
            return currentbalance;
            
        }
        static double Withdraw(double withdrawamount, double initialbalance)
        {
            double currentbalance = initialbalance - withdrawamount;
            return currentbalance;
             
        }
        
        static void Main(string[] args)
        {
            double initialbalance = 10000;
            string answer;
            string reset = "N";
            do
            {
                Console.WriteLine("What transaction would you wish to perform? \n1.Deposit\n2.Withdraw\n3.Check Balance");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1" :
                        Console.WriteLine("Enter the amount you wish to deposit:");
                        double depoamount = double.Parse(Console.ReadLine());
                        double a = Deposit(depoamount, initialbalance);
                        Console.WriteLine("Your current balance after deposit is: Ksh " + a);
                        initialbalance = a;

                        break;

                    case "2":
                            Console.WriteLine("Enter the amount you wish to withdraw:");                           
                            double withdrawamount = double.Parse(Console.ReadLine());
                            double b = Withdraw(withdrawamount, initialbalance);
                            if (withdrawamount < initialbalance)
                            {
                                Console.WriteLine("Your current balance after withdrawal is: Ksh "  + b);
                                initialbalance = b;

                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Your withdrawal amount exceeds current balance! Your current balance is: Ksh " + initialbalance);
                                Console.ResetColor();
                            }
                        break;


                    case "3" :
                        Console.WriteLine("Your current balance is: Ksh " + initialbalance);
                        break;

                }
                Console.WriteLine("Do you wish to perform another transaction(Y/N)");
                reset = Console.ReadLine();
              
            }
            while (reset != "N");

        }
    }
}
