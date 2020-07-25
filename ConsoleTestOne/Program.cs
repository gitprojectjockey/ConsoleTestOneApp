using System;

namespace ConsoleTestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Foo.GetFooBar());
        }

        public static class Foo
        {
            public static string GetFooBar()
            {
                return "foobar";
            }
        }


    }
}
