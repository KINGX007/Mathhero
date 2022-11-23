using System;
namespace Mathhero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int health = 3;
            int ans=0;
            int wrg=0;
            for (int i = 1; i < 11; i++)
            {
                if(health==0)
                {
                    goto gameover;
                }
                Random numgen = new Random();
                int num1 = numgen.Next(1, 11);
                int num2 = numgen.Next(1, 11);
                Console.WriteLine("What is " + num1 + " * " + num2 + " equal to ???");
                int Answer = Convert.ToInt32(Console.ReadLine());
                if (Answer == num1 * num2)
                {
                    int ran = numgen.Next(1, 4);
                    switch (ran)
                    {
                        case 1:
                            Console.WriteLine("Good work!!");
                            break;
                        case 2:
                            Console.WriteLine("Nice!!!");
                            break;
                        default:
                            Console.WriteLine("Excellent!!");
                            break;
                    }
                    Console.WriteLine();
                    ans++;
                    health++;
                    Console.WriteLine("Health=" + health);
                }
                else
                {
                    int ran = numgen.Next(1, 4);
                    switch (ran)
                    {
                        case 1:
                            Console.WriteLine("Wrong!!");
                            break;
                        case 2:
                            Console.WriteLine("Try hard!!!");
                            break;
                        default:
                            Console.WriteLine("DO homework!!");
                            break;
                    }
                    Console.WriteLine();
                    wrg++;
                    health--;
                    Console.WriteLine("Health="+health);
                }
            }
            Console.WriteLine("Test Ended!!!");
            Console.WriteLine("Amount of Correct answers="+ans);
            Console.WriteLine("Amount of Wrong answers="+wrg);

        gameover:
            Console.WriteLine("You died");

        }
    }
}
