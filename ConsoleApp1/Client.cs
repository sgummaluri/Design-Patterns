using System;

namespace Facade
{
    /// <summary>
    /// The driver class that invokes the FacadeClass that is following the Facade pattern
    /// </summary>
    public class Client
    {
        static void Main(string[] args)
        {
            FacadeClass facade = new FacadeClass();
            Console.WriteLine(facade.TurnOffComputerAndMonitor());
            Console.ReadLine();
        }
    }
}
