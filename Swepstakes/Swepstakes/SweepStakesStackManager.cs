using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Swepstakes
{
    public class SweepStakesStackManager : ISweepstaeksManager
    {
        //stackmamager data structrue
        Stack<SweepStakes> stack = new Stack<SweepStakes> ();

        //insert sweepstakes
        public void InsertSweepstakes(SweepStakes sweeptakes)
        {

        }

        // get sweepstakes
        public SweepStakes GetSweepstakes();

    }

}
