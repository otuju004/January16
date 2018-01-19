using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGitDemo2
{
    public class Program
    {
        public static void Main()
        {
            string[] drinks = { "Coffee", "Tea", "Juice", "Milk", "Water", "Sarsaparilla",
                "Carbonated Drink", "Lemonade", "Soda", "Ice Tea", "Ginger Beer", "Root Beer",
            "Smoothie", "Protein Shake", "Soy Milk" };
            Random rnd = new Random();
            int index = rnd.Next(0, drinks.Length);
            Console.WriteLine("Have we earned a {0} break, youngsters?", drinks[index]);
            //Something something Feature 1
        }
    }

}

