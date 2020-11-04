﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    class Simulation
    {
        public Simulation()
        {

        }
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager newManager;
            string choice;
            MarketingFirm firm;
            choice = UserInterface.GetUserInputFor();
            newManager = SweepStakesManagerFactory.SetNewMarketingManager(choice);
            firm =  new MarketingFirm(newManager);
            
        }
    }
    
}
