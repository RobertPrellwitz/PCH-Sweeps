using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Swepstakes
{
    static class UserInterface
    {
        static UserInterface()
        {

        }
        public static void Hello()
        {
            Console.WriteLine("Welcome to the SweepStakes Manager");
        }

        public static Contestant createContestant(SweepStakes sweepStakes)
        {
            Contestant newContestant = new Contestant();
            Console.WriteLine("Please input contestant first name:");
            newContestant.firstName = Console.ReadLine();
            newContestant.lastName = Console.ReadLine();
            newContestant.email = Console.ReadLine();
            newContestant.registrationNumber= sweepStakes.registrationCounter(sweepStakes);
            
            return newContestant;
                
        }
    }
        
}
