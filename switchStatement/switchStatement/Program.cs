using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ronaldo, Suarez, Neymar, Ronaldo are running for best football player in the world who do you think will win?");
            string input;

            do
            {
                Console.WriteLine("Who will win? choose between: neymar, suarez, messi, ronaldo");
                input = Console.ReadLine();



            switch (input)
                {
                    case "neymar":
                    case "messi":
                        Console.WriteLine("Good choice he probably wins as he is one of the best player in the world!");

                        break;

                    case "ronaldo":

                        Console.WriteLine("No good enough");

                        break;

                    default:
                        Console.WriteLine("I'm sorry, I don't understand that!");

                        break;
                }
            } while (input != "i dont know");
    
            Console.WriteLine("Press a key to exit.");
            Console.ReadLine();
        }
    }
}
