using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Automobile
{
    public class MercCClass : IAuto
    {
        public void Run()
        {
            Console.WriteLine("Merc C Class Running");
        }
    }
}
