using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.interfaces;

namespace GameIdeaGenerator.utility
{
    public class UserInput
    {
        List<GameType> availableGameTypes = Enum.GetValues(typeof(GameType)).Cast<GameType>().ToList();
        public UserInput()
        {

        }
        public List<GameType> UserTypesInput(List<GameType> gameTypes)
        {
            List<GameType> userGameTypes = new List<GameType>();
            foreach (var v in gameTypes)
            {
                if (availableGameTypes.Contains(v))
                {
                    userGameTypes.Add(v);
                }
            }
            return userGameTypes;
        }


    }
}
