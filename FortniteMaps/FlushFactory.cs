using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class FlushFactory : Map
    {
        public override string MapName
        {
            get
            {
                return "Flush Factory";
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
