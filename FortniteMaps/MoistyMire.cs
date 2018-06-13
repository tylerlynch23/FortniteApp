using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class MoistyMire : Map
    {
        public override string MapName
        {
            get
            {
                return "Moisty Mire";
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
