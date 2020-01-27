using System;

namespace Guess_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int misterio = r.Next(1,100);

            Console.WriteLine("Hello!");
            Console.WriteLine("I'm thinking of a number. What is it?");

            bool gotit = false;
            int tries = 1;

            while (!gotit)
            {
                
                int n;
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("That's not a number, dummy!");
                }
                else
                {
                    if (n == misterio)
                    {
                            Console.WriteLine("You got it! The number was {0} and it took you {1} tries.", misterio, tries);
                            gotit = true;
                    }
                    else
                    {
                        Console.WriteLine("Oops... Thats not the right one!");
                        tries = tries + 1;
                        if (misterio > n)
                        {
                            Console.WriteLine("You need to go higher!");
                        }
                        else
                        {
                            Console.WriteLine("You need to go lower!");
                        }
                    }
                }
            }            



        }
    }
}
