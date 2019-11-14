using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var secretnumber = new Random().Next(1, 10);
            Console.WriteLine("The secret number is: {0}", secretnumber);

            for (var i = 0; i < 3; i++)
            {
                Console.Write("Guess the secret number: ");
                var guessnumber = int.Parse(Console.ReadLine());

                if (secretnumber == guessnumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }

    }
}
/*
The secret number is: 2
Guess the secret number: 9
Guess the secret number: 6
Guess the secret number: 3
You lost
Press any key to continue . . .
*/
