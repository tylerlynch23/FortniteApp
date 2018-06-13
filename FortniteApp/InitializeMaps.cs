using FortniteMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FortniteApp
{
    public class InitializeMapsList
    {
        public List<string> mapList;
        public Type[] derivedMapTypes;

        public InitializeMapsList()
        {
            mapList = new List<string>();
        }

        public void PopulateMapList()
        {
            //Loads all map types into list
            Type mapType = typeof(Map);          
            Type[] mapTypes = Assembly.GetAssembly(mapType).GetTypes();
            derivedMapTypes = (from Type type in mapTypes
                               where type.IsSubclassOf(typeof(Map))
                               select type).ToArray();
        }



    }
    

}
