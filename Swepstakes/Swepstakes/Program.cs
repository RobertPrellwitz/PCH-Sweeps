using System;

namespace Swepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Simulation tester = new Simulation();
            tester.CreateMarketingFirmWithManager();

        }
    }
}
