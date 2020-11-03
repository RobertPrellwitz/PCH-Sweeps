using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Swepstakes
{
    public class SweepStakesStackManager : ISweepstakesManager
    {
        //stackmamager data structrue
        Stack<SweepStakes> stack = new Stack<SweepStakes> ();
        public SweepStakesStackManager()
        {
            
        }

        //insert sweepstakes
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        // get sweepstakes
        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
            
        }

    }

}
