using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class SnobbyShores : Map
    {
        public override string MapName
        {
            get
            {
                return "SnobbyShores";
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
