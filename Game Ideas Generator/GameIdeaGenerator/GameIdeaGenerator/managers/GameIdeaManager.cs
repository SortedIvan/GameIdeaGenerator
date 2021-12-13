using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.interfaces;


namespace GameIdeaGenerator.managers
{
    public class GameIdeaManager
    {

        private List<GameIdea> gameIdeas;

        public GameIdeaManager()
        {
            this.gameIdeas = new List<GameIdea>();
        }


        public void AddGameIdeaToList(GameIdea gameIdea)
        {
            this.gameIdeas.Add(gameIdea);
        }


        public List<GameIdea> GetGameIdeas()
        {
            return this.gameIdeas;
        }

        public GameIdea GetGameIdeaById(long id)
        {
            return this.gameIdeas.ElementAt((int)id);
        }


    }
}
