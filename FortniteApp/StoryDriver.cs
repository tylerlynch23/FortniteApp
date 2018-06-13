using FortniteMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            foreach(Map map in InitializeMapsList.mapList)
            {
                Console.WriteLine(map);
            }
            Console.ReadKey();

        

        
        }
    }
}
