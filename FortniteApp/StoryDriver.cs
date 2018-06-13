using FortniteMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FortniteApp
{
    class StoryDriver
    {

        
        public void MainStoryLoop()
        {
            Console.WriteLine("Welcome to Fortnite Text-Based Adventure! What is your username?");
            string username = Console.ReadLine();

            Console.WriteLine("Awesome " + username + ", where would you like to land?");
            Console.WriteLine("------------------------------------------------");
            foreach(Type map in InitializeMapsList.derivedMapTypes)
            {
                InitializeMapsList.mapList.Add(map.Name);
                string currentMapName = Regex.Replace(map.Name, "([a-zA-Z])_?([A-Z])", "$1 $2");
                Console.WriteLine(currentMapName);
                

            }
            Console.WriteLine("------------------------------------------------");
            string playerLandingSpot = Console.ReadLine();

        

        
        }
    }
}
