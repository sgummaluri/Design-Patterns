using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Automobile
{
    public class MercSClass : IAuto
    {
        public void Run()
        {
            Console.WriteLine("Merc S Class Running");
        }
    }
}
