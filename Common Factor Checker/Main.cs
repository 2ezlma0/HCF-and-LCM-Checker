using System;

namespace HCF_and_LCM_Chcker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notChosen = true;

            Console.WriteLine("Press '1' for the highest common factor calculator, press '2' for the lowest common multiple calculator");
            while (notChosen)
            {
                string oneTwo = Console.ReadLine();
                if (oneTwo == "1")
                {
                    HCF();
                    notChosen = false;
                }
                else if (oneTwo == "2")
                {
                    LCM();
                    notChosen = false;
                }
                else
                {
                    Console.WriteLine("Please enter either '1' or '2'");
                }
            }
        }

        public static void HCF()
        {
            int b = 1;
            bool tryAgainFactor = true;
            
            while (tryAgainFactor)
            {
                bool highestCommonFactorFound = false;
                Console.WriteLine("This program finds the highest common factor of 2 numbers");
                Console.WriteLine("Please enter number 1");
                int numA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter number 2");
                int numB = Convert.ToInt32(Console.ReadLine());
                
                if (numA > numB)
                {
                    b = numA;
                }                
                else if (numA < numB)
                {
                    b = numB;
                }
                else
                {
                    b = numA;
                }

                while (highestCommonFactorFound == false)
                { 
                    if (numA % b == 0 && numB % b == 0)
                    {
                        Console.WriteLine("Highest common factor is " + b);
                        highestCommonFactorFound = true;
                    }
                    b--;
                }
                
                Console.WriteLine("Do you want to use again? Y/N");
                string yn = Console.ReadLine();
                bool falseyn = true;
                while (falseyn)
                {
                    if (yn != "Y" && yn != "N")
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        yn = Console.ReadLine();
                    }
                    else
                    {
                        falseyn = false;
                    }
                    
                    if (yn == "N")
                    {
                        tryAgainFactor = false;
                    }
                }
            }
        }

        public static void LCM()
        {
            int a = 1;
            bool tryAgainMultiple = true;
            
            while (tryAgainMultiple)
            {
                bool lowestCommonMultipleFound = false;
                Console.WriteLine("This program finds the lowest common multiple of 2 numbers");
                Console.WriteLine("Please enter number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                while (lowestCommonMultipleFound == false)
                {
                    if (a % num1 == 0 && a % num2 == 0)
                    {
                        Console.WriteLine("Lowest common multiple is " + a);
                        lowestCommonMultipleFound = true;
                    }
                    a++;
                }
                
                Console.WriteLine("Do you want to use again? Y/N");
                string YN = Console.ReadLine();
                if (YN == "N")
                {
                    tryAgainMultiple = false;
                }
                bool falseyn = true;
                while (falseyn)
                {
                    if (YN != "Y" && YN != "N")
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        YN = Console.ReadLine();
                    }
                    else
                    {
                        falseyn = false;
                    }
                    
                    if (YN == "N")
                    {
                        tryAgainMultiple = false;
                    }
                }
            }
        }
    }
}
