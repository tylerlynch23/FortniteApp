using FortniteMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FortniteApp
{
    static class InitializeMapsList
    {
        public static List<Map> mapList;

        static InitializeMapsList()
        {
            mapList = new List<Map>();
        }

        public static void PopulateMapList()
        {
            //Loads all map types into list
            Type mapType = typeof(Map);          
            Type[] types = Assembly.GetAssembly(mapType).GetTypes();
            Type[] possible = (from Type type in types
                               where type.IsSubclassOf(typeof(Map))
                               select type).ToArray();
        }

    }
    

}
