using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Automobile
{
    public class Ferrari250 : IAuto
    {
        public void Run()
        {
            Console.WriteLine("Ferrari 250 Running");
        }
    }
}
