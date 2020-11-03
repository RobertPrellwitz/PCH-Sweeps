using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // queue data structure
        Queue<SweepStakes> queue = new Queue<SweepStakes>();

        public SweepstakesQueueManager()
        { 
        }


        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        // get sweepstakes
        public SweepStakes GetSweepStakes()

        { 
            return queue.Dequeue();
        }
    }

}
