using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class GreasyGrove : Map
    {
        public override string MapName
        {
            get
            {
                return "Greasy Grove";
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
