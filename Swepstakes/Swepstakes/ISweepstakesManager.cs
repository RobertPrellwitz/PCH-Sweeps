using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Swepstakes
{
    public interface ISweepstakesManager
    {
        
        void InsertSweepstakes(SweepStakes sweepStakes);

        SweepStakes GetSweepStakes();

    }
}
