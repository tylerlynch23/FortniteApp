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
        private string UsersCurrentLocation;
        private List<string> LocationList = new List<string>();

        public void MainStoryLoop()
        {
            //Introduction and Username input
            Console.WriteLine("Welcome to Fortnite Text-Based Adventure! What is your username?");
            string username = Console.ReadLine();
            Console.WriteLine("Awesome " + username + ", where would you like to land?");
            Console.WriteLine("------------------------------------------------");
            //List of all maps is listed
            foreach (Type map in Program.initializeMapsList.derivedMapTypes)
            {
                //Map names WITHOUT spaces is added to static mapList
                Program.initializeMapsList.mapList.Add(map.Name);
                //Regex used to add a space inbetween the words (delimeted by lowercase and uppercase shift)
                string currentLocationName = Regex.Replace(map.Name, "([a-zA-Z])_?([A-Z])", "$1 $2");
                //Adding this edited map name to our member array for use in the rest of the class
                LocationList.Add(currentLocationName);
                Console.WriteLine(currentLocationName);
            }
            Console.WriteLine("------------------------------------------------");
            //If user enters in an invalid map location, keep going until they do.
            bool isInputInvalid = true;
            while (isInputInvalid)
            {
                try
                {
                    //Check if user entry is contained in our LocationList
                    string playerLandingSpot = Console.ReadLine();
                    if (LocationList.Contains(playerLandingSpot))
                    {
                        UsersCurrentLocation = playerLandingSpot;
                        isInputInvalid = false;
                    }
                    else
                    {
                        throw new Exception();
                    }                    
                }
                catch
                {
                    Console.WriteLine("Whoops! That's not a valid map location.. Enter one of the locations listed above");
                }
            }
            //testing - delete later
            Console.WriteLine("SUCCESS");
            Console.ReadKey();
        }
    }
}
