using AbstractFactory.Contracts;
using System;

namespace AbstractFactory.Automobile
{
    public class FerrariF40 : IAuto
    {
        public void Run()
        {
            Console.WriteLine("Ferrari F40 Running");
        }
    }
}
