using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo10
{
    internal class Helpers
    {
        public static void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public static void MyLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static int CoolFeature(int num1, int num2)
        {
            return num1 * num2;
        }

        public static string TellJoke()
        {
            return "Why shouldn’t you write with a broken pencil? Because it’s pointless";
        }
    }
}
