using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    public class SweepStakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get; set; }
        public int RegistrationNumber=0;
        Random rand;

        public SweepStakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber,contestant);
        }

        public void PrintContestandInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant First Name: {contestant.firstName}");
            Console.WriteLine($"Contestant Last Name: {contestant.lastName}");
            Console.WriteLine($"Contestant email address: {contestant.email}");
            Console.WriteLine($"Contestant Registration Number: {contestant.registrationNumber}");

        }

        public int registrationCounter(SweepStakes sweepStakes)
        {
            RegistrationNumber = RegistrationNumber + 1;
            return RegistrationNumber;
        }

        public Contestant PickWinner()
        {
            rand = new Random();
            int i;
            i = rand.Next(RegistrationNumber);
            
            return contestants[i];
        }
    }
}


       

