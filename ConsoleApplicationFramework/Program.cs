using System;

using ClassLibrary1;

namespace ConsoleApplicationFramework {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            var use = new Class1("Framework");
            Console.WriteLine(use.Method1("From Framework") + use.Prop1);
        }
    }
}