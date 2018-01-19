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
            string[] colours = { "Coffee", "Tea", "Juice", "Milk", "Water", "Sarsaparilla" };
            Random rnd = new Random();
            int index = rnd.Next(0, colours.Length);
            Console.WriteLine("Have we earned a {0} break, youngsters?", colours[index]);
            //Something something Feature 1
        }
    }

}

