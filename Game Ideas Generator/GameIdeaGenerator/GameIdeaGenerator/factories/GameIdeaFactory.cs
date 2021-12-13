using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.interfaces;

namespace GameIdeaGenerator.factories
{
    public class GameIdeaFactory : IGameIdeaFactory
    {

        public GameIdeaFactory()
        {
            
        }



        public GameIdea CreateGameIdea(List<string> keywords, List<GameType> gameTypes)
        {
            if (gameTypes.Count <= 0)
            {
                return null;
            }
            GameIdea gameIdea = new GameIdea(keywords, gameTypes);
            return gameIdea;
        }
    }
}
