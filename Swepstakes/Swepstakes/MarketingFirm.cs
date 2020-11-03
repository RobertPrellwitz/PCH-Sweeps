using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;


        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepstakes()
        {
            SweepStakes sweepStakes = new SweepStakes();
            manager.InsertSweepstakes(sweepStakes);
            

        }
        
    }
}
