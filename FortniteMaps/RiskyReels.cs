using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class RiskyReels : Map
    {
        public override string MapName
        {
            get
            {
                return "Risky Reels";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 9;
            }
        }
    }
}
