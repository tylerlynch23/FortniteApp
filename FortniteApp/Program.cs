using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteApp
{
    class Program
    {
        public static InitializeMapsList initializeMapsList = new InitializeMapsList();
        public static StoryDriver storyDriver = new StoryDriver();

        static void Main(string[] args)
        {
            initializeMapsList.PopulateMapList();
            storyDriver.MainStoryLoop();
        }
    }
}
