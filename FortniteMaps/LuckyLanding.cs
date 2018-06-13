using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class LuckyLanding : Map
    {
        public override string MapName
        {
            get
            {
                return "Lucky Landing";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 6;
            }
        }
    }
}
