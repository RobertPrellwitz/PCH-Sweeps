using System;
using System.Collections.Generic;
using System.Text;

namespace Swepstakes
{
    static class SweepStakesManagerFactory
    {

        public static ISweepstakesManager SetNewMarketingManager(string choice)
        {
            switch (choice)
            {
                case "stack":

                    return new SweepStakesStackManager();


                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return new SweepStakesStackManager();
            }

        }

      


    }

}
