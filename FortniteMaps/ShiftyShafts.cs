using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class ShiftyShafts : Map
    {
        public override string MapName
        {
            get
            {
                return "Shifty Shafts";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 4;
            }
        }
    }
}
