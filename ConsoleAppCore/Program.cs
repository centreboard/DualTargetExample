using System;

using ClassLibrary1;

namespace ConsoleAppCore {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            var use = new Class1("Core");
            Console.WriteLine(use.Method1("From Core") + use.Prop1);
        }
    }
}