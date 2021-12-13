using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.enums;

namespace GameIdeaGenerator.models
{
    public class GameIdea
    {
        private long id;
        private string gameTitle;
        private string world;
        private List<GameType> gameTypes;
        private List<string> keywords;

        public GameIdea(List<string> keywords, List<GameType> gameTypes)
        {
            this.keywords = keywords;
            this.gameTypes = gameTypes;
        }

        public string GameTitle { get { return this.gameTitle; } set { this.gameTitle = value;} }
        public string World { get { return this.world; } set { this.world = value; } }
        public List<GameType> GameTypes { get { return this.gameTypes; } set { this.gameTypes = value; } }
        public List<string> Keywords { get { return this.keywords; } set { this.keywords = value; } }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
