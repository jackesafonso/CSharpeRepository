using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOfBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfFruits = { "orange", "mango", "banana", "apple" };

            List<string> myFruits = new List<string>() { "orange", "mango", "banana", "apple" };

            Console.WriteLine("Here you have the list of fruits");
            Console.WriteLine("to exit press x");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch(response)
                {
                    case 'A':

                }


            }

            //you can sort List<string>!
            list.Sort();

            list.Add("lemon");
            list.Remove("mango");


            //list.Remove("4");//remove specieifed item.
            // list.RemoveAt(2);//remove item from index.
            // list.RemoveRange(1, 2);//remove a range of items.

            Console.WriteLine(); 
            Console.ReadLine(); 

        }

        
    }
}
