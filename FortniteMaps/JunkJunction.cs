using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class JunkJunction : Map
    {
        public override string MapName
        {
            get
            {
                return "Junk Junction";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 1;
            }
        }
    }
}
