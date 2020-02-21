using System;

namespace lab_3._5lloyd
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = " MILF";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord)) 
            {
                isSpam = true;
                Console.WriteLine("the message is spam");
            }
            
            else
            {
                isSpam = false;
                Console.WriteLine("the message is not spam.");
            }

        }
    }
}

