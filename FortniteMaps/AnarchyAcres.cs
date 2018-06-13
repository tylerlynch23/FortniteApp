using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    class AnarchyAcres : Map
    {
        public override string MapName
        {
            get
            {
                return "Anarchy Acres";
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
