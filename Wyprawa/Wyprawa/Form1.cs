using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void swordEq_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                swordEq.BorderStyle = BorderStyle.FixedSingle;
                bowEq.BorderStyle = BorderStyle.None;
                maceEq.BorderStyle = BorderStyle.None;
                potionRedEq.BorderStyle = BorderStyle.None;
                potionBlueEq.BorderStyle = BorderStyle.None;    
            }
        }

        private void bowEq_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Łuk"))
            {
                game.Equip("Łuk");
                swordEq.BorderStyle = BorderStyle.None;
                bowEq.BorderStyle = BorderStyle.FixedSingle;
                maceEq.BorderStyle = BorderStyle.None;
                potionRedEq.BorderStyle = BorderStyle.None;
                potionBlueEq.BorderStyle = BorderStyle.None;
            }
        }

        private void maceEq_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Buława"))
            {
                game.Equip("Buława");
                swordEq.BorderStyle = BorderStyle.None;
                bowEq.BorderStyle = BorderStyle.None;
                maceEq.BorderStyle = BorderStyle.FixedSingle;
                potionRedEq.BorderStyle = BorderStyle.None;
                potionBlueEq.BorderStyle = BorderStyle.None;
            }
        }

        private void potionRedEq_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                game.Equip("Czerwona mikstura");
                swordEq.BorderStyle = BorderStyle.None;
                bowEq.BorderStyle = BorderStyle.None;
                maceEq.BorderStyle = BorderStyle.None;
                potionRedEq.BorderStyle = BorderStyle.FixedSingle;
                potionBlueEq.BorderStyle = BorderStyle.None;
            }
        }

        private void potionBlueEq_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                game.Equip("Niebieska mikstura");
                swordEq.BorderStyle = BorderStyle.None;
                bowEq.BorderStyle = BorderStyle.None;
                maceEq.BorderStyle = BorderStyle.None;
                potionRedEq.BorderStyle = BorderStyle.None;
                potionBlueEq.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
