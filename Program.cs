using System;
using hello_c_2;

namespace hello_c_
{

    class AnotherClass 
    {
        private string name = "my name";

        public AnotherClass(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new MyClass(26);
            Console.WriteLine(myClass.GetAge() - 1);   

            AnotherClass anotherClass = new AnotherClass("another name");
            Console.WriteLine(anotherClass.GetName());   
        }
    }
}
