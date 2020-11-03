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


        }

        public int registrationCounter(SweepStakes sweepStakes)
        {
            RegistrationNumber = RegistrationNumber + 1;
            return RegistrationNumber;
        }

        public Contestant PickWinner()
        {
            int i=0; 
            // Random number generator for i

            return contestants[i];
        }
    }
}


       

