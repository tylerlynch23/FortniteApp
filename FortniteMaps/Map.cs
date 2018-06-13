using System;
using System.Collections.Generic;
using System.Text;

namespace FortniteMaps
{
    public abstract class Map
    {
        public abstract string MapName { get; }
        public abstract int HowManyPeopleGoToArea { get;}
        
        public Map()
        {

        }
    }
}
