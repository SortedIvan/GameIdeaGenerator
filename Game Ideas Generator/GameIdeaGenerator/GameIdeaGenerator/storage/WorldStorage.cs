using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;


namespace GameIdeaGenerator.storage
{
    public class WorldStorage
    {

        public WorldStorage()
        {

        }

        public List<string> GetWorldNames(GameType userGameType)
        {
            List<string> worldName = new List<string>();
        //Adventure,
        //Sci_Fi,
        //Arcade,
        //Rougue_Lite,
        //Horror,
        //Musical,
        //Shooter,
        //Puzzle


            //20 per if statement

                if (userGameType.Equals(GameType.Adventure))
                {
                    worldName.Add("Hemwick");
                    worldName.Add("Argus");
                    worldName.Add("Tempera");
                    worldName.Add("Hedelven");
                    worldName.Add("Argath");
                    worldName.Add("Bederoth");
                    worldName.Add("Lukreth");

                }


            return worldName;
        }










    }
}
