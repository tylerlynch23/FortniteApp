using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class LootLake : Map
    {
        public override string MapName
        {
            get
            {
                return "Loot Lake";
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
