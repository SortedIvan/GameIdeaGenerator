using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.utility;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.factories;

//TODO: Dependency Injection for WorldGenerator


namespace GameIdeaGenerator.main
{
    public class Main
    {
        private WorldGenerator worldGenerator;
        private UserInput userInput;

        public Main(WorldGenerator worldGenerator, UserInput userInput)
        {
            this.worldGenerator = worldGenerator;
            this.userInput = userInput;
        }

        public WorldGenerator WorldGenerator
        {
            get
            {
                return this.worldGenerator;
            }

        }

    }
}
