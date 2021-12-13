using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameIdeaGenerator.models;
using GameIdeaGenerator.enums;
namespace GameIdeaGenerator.interfaces
{
    public interface IGameIdeaFactory
    {
        GameIdea CreateGameIdea(List<string> keywords, List<GameType> gameTypes);

    }
}
