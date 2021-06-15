using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            myClass myVariable = new myClass();
            myVariable.MyMethod<string>("string1", "string2");

            Console.WriteLine(myVariable.MyProperty1);
            Console.WriteLine(myVariable.MyProperty2);

        }
    }

    public class myClass
    {
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }

        public void MyMethod<T>(T parameter1, T parameter2)
        {
            this.MyProperty1 = parameter1.ToString();
            this.MyProperty2 = parameter2.ToString();
        }
        
    }
}
