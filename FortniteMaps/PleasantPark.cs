using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class PleasantPark : Map
    {
        public override string MapName
        {
            get
            {
                return "Pleasant Park";
            }
        }

        public override int HowManyPeopleGoToArea
        {
            get
            {
                return 8;
            }
        }
    }
}
