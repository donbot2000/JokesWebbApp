using System;
using System.Dynamic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Value = 1;
            MyClass mc2 = mc;
            mc2.Value = 2;
            Console.WriteLine(mc.Value);
             
            MyStruct ms1 = new MyStruct();
            ms1.Value = 1;
            MyStruct ms2 = ms1;
            ms2.Value = 2;
            Console.WriteLine(ms1.Value);
             
            double n =double.Parse(Console.ReadLine());
            Console.WriteLine(n);
            Console.WriteLine("asd");
             

        }
    }

    struct MyStruct 
    {
        public int Value { get; set; }
    }

    class MyClass
    {
        public int Value { get; set; }
    }
}
