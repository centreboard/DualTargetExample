using System;

using ClassLibrary1;

namespace ConsoleAppFramework {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            var use = new Class1();
            Console.WriteLine(use.Method1("From Framework"));
        }
    }
}