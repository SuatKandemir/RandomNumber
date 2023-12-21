
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int num1;

        do
        {
            Console.Clear(); 
            Console.WriteLine("Enter a number between 1-10");
            num1 = Convert.ToInt32(Console.ReadLine());

            int randomnumber = random.Next(1, 11);
            Console.WriteLine("Random number: " + randomnumber);

            if (randomnumber == num1)
            {
                Console.WriteLine("You won! Your number matched with the random number: " + randomnumber);
                break; 
            }
            else
            {
                Console.WriteLine("Sorry! Try again.");
                Thread.Sleep(1000);
            }

        } while (true); 

       
    }
}
