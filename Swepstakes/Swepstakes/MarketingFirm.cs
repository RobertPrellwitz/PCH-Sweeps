using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;

        // dependency injection (constructor injection)
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepstakes()
        {
            SweepStakes PCHsweepStakes = new SweepStakes();
            manager.InsertSweepstakes(PCHsweepStakes);
            

        }
        
    }
}
