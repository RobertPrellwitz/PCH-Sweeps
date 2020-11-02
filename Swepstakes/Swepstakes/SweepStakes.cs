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


        public SweepStakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public void PrintContestandInfo(Contestant contestant)
        {


        }

        public Contestant PickWinner()
        {
            int i=0; 
            // Random number generator for i

            return contestants[i];
        }
    }
}


       

