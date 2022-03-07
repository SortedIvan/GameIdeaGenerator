using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIdeaGenerator.models
{
    public class World
    {
        private string worldName;
        private string worldDescription;
        public World(string worldName, string worldDescription)
        {
            this.worldDescription = worldDescription;
            this.worldName = worldName;
        }

        public string GetWorldName()
        {
            return this.worldName;
        }
        public void SetWorldName(string newWorldName)
        {
            this.worldName = newWorldName;
        }

        public string GetWorldDescription()
        {
            return this.worldDescription;
        }
        public void SetWorldDescription(string worldDescription)
        {
            this.worldDescription = worldDescription;
        }
    }
}
