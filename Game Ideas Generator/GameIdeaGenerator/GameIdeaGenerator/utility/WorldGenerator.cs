using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.interfaces;


//TODO: Implement methods that check the userInput ( Inputted GameTypes)
//Add keywords
namespace GameIdeaGenerator.utility
{
    public class WorldGenerator
    {
        private UserInput userInput;
        private WorldNameGenerator worldNameGenerator;

        public WorldGenerator(UserInput userInput)
        {
            this.userInput = userInput;
        }

        public World CreateWorld(List<GameType> userGameTypes)
        {
            //Name generation
            worldNameGenerator.GetWorldGen(userGameTypes);
            World world = new World(worldNameGenerator.GetWorldGen(userGameTypes), "");
            return world;

        } 

        

    }
}
