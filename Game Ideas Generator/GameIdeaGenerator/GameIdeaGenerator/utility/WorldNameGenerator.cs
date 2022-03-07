using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.storage;

namespace GameIdeaGenerator.utility
{
    public class WorldNameGenerator
    {
        public WorldStorage worldStorage;
        
        public string GetWorldGen(List<GameType> userGameTypes)
        {
            string worldName = "";
            foreach(var v in userGameTypes)
            {
                if (v.Equals(GameType.Adventure))
                {
                    List<int> randInt = this.RandomNumberGenerator();
                    switch (randInt.ElementAt(1))
                    {
                        case 0:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(0);
                            break;
                        case 1:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(1);
                            break;
                        case 2:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(2);
                            break;
                        case 3:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(3);
                            break;
                        case 4:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(4);
                            break;
                        case 5:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(5);
                            break;
                        case 6:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(6);
                            break;
                    }
                }
                if (v.Equals(GameType.Sci_Fi))
                {
                    List<int> randInt = this.RandomNumberGenerator();
                    switch (randInt.ElementAt(1))
                    {
                        case 0:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(0);
                            break;
                        case 1:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(1);
                            break;
                        case 2:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(2);
                            break;
                        case 3:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(3);
                            break;
                        case 4:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(4);
                            break;
                        case 5:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(5);
                            break;
                        case 6:
                            worldName += worldStorage.GetWorldNames(GameType.Adventure).ElementAt(6);
                            break;
                    }
                }
            }


            return worldName;
        }


        public WorldNameGenerator()
        {
            this.worldStorage = new WorldStorage();
        }


        private List<int> RandomNumberGenerator()
        {
            List<int> randomInts = new List<int>();
            Random randomInt = new Random();

            int secondRandomInt = randomInt.Next(0, 6);
            int firstRandomInt = randomInt.Next(11, 20);

            randomInts.Add(secondRandomInt);
            randomInts.Add(firstRandomInt);

            return randomInts;
           
        }

    }
}
