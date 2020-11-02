using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    interface ISweepstaeksManager
    {
        public void InsertSweepstakes(SweepStakes sweepstakes);
        SweepStakes GetSweepstakes();
    }
}
