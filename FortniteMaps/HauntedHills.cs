using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class HauntedHills : Map
    {
        public override string MapName
        {
            get
            {
                return "Haunted Hills";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 2;
            }
        }
    }
}
