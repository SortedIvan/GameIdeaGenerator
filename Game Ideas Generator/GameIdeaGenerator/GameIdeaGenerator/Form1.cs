using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameIdeaGenerator.enums;
using GameIdeaGenerator.storage;
using GameIdeaGenerator.utility;
using GameIdeaGenerator.main;
namespace GameIdeaGenerator
{
    public partial class Form1 : Form
    {
        private Main main;
        private WorldGenerator worldGenerator;
        private UserInput userInput;
        public Form1()
        {
            InitializeComponent();
            this.userInput = new UserInput();
            this.worldGenerator = new WorldGenerator(userInput);
            this.main = new Main(worldGenerator,userInput);
        }

        private void btnGenerateIdea_Click(object sender, EventArgs e)
        {
            List<GameType> gameTypes = new List<GameType>();
            GameType gameType = (GameType)Enum.Parse(typeof(GameType), this.cbxGameType.SelectedItem.ToString());
            gameTypes.Add(gameType);
            this.lbxAddedGenres.Items.Add(this.main.WorldGenerator.CreateWorld(gameTypes));

        }
    }
}
