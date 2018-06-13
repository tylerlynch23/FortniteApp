using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class WailingWoods : Map
    {
        public override string MapName
        {
            get
            {
                return "Wailing Woods";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 5;
            }
        }
    }
}
