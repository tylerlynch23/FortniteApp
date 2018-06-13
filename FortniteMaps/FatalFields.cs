using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class FatalFields : Map
    {
        public override string MapName
        {
            get
            {
                return "Fatal Fields";
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
