using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class DustyDivot : Map
    {
        public override string MapName
        {
            get
            {
                return "Dusty Divot";
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
