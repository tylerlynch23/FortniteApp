using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class LonelyLodge : Map
    {
        public override string MapName
        {
            get
            {
                return "Lonely Lodge";
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
