using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedContext
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                const char AlphaA = 'a';
                for(byte i = 0; i < 255; i++)
                {
                    if (i + 0x20 == AlphaA) Console.WriteLine("match 'A'!");
                }
            }
        }
    }
}
