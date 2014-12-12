using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> items = new GenericStack<int>(5);
            Console.WriteLine("Int type Stack:");
            items.Push(11);
            items.Push(12);
            items.Push(13);
            items.Push(14);
            Console.WriteLine(items.Pop());
            Console.WriteLine(items.Pop());
            Console.WriteLine(items.Pop());
            Console.WriteLine(items.Pop());
            GenericStack<string> itemss = new GenericStack<string>(5);
            Console.WriteLine("String type Stack:");
            itemss.Push("Ash");
            itemss.Push("Maloncho");
            itemss.Push("Ayesha");
            itemss.Push("Siddiqua");
            Console.WriteLine(itemss.Pop());
            Console.WriteLine(itemss.Pop());
            Console.WriteLine(itemss.Pop());
            Console.WriteLine(itemss.Pop());
            Console.ReadKey();
        }
    }
}
