using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryDriver storyDriver = new StoryDriver();
            InitializeMapsList.PopulateMapList();
            storyDriver.MainStoryLoop();
        }
    }
}
