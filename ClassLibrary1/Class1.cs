using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Prop1 { get; }

        public Class1(string arg1) {
            this.Prop1 = arg1;

        }
        
        public string Method1(string param1) {
            return $"Hello {param1}";
        }
    }
}
