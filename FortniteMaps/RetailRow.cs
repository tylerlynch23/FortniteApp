using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class RetailRow : Map
    {
        public override string MapName
        {
            get
            {
                return "Retail Row";
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
