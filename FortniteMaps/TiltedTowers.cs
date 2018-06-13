using System;
using System.Collections.Generic;

namespace FortniteMaps
{
    public class TiltedTowers : Map
    {
        public override string MapName
        {
            get
            {
                return "Tilted Towers";
            }
        }
    
        public override int HowManyPeopleGoToArea {
            get
            {
                return 18;
            }
        }
    }
}
