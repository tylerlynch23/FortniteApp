using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class SaltySprings : Map
    {
        public override string MapName
        {
            get
            {
                return "Salty Springs";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 3;
            }
        }
    }
}
