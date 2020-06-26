using CaseConverters;
using System;

namespace CaseConsole
{
    class Program
    {
        static void Main()
        {
            string name = "LongIdentifierName";

            string kebabbed = name.ToKebab('_');

            Console.WriteLine(name);
            Console.WriteLine(kebabbed);
        }
    }
}
