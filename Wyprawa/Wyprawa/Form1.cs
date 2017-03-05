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

        private void upMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void rightMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void downMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void upAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void rightAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void downAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            playerPicture.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat == true)
                bat.Visible = true;
            else
                bat.Visible = false;

            if (showGhost == true)
                ghost.Visible = true;
            else
                ghost.Visible = false;

            if (showGhoul == true)
                ghoul.Visible = true;
            else
                ghoul.Visible = false;

            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            potionRed.Visible = false;
            potionBlue.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = sword; break;
                case "Łuk":
                    weaponControl = bow; break;
                case "Buława":
                    weaponControl = mace; break;
                case "Czerwona mikstura":
                    weaponControl = potionRed; break;
                case "Niebieska mikstura":
                    weaponControl = potionBlue; break;
            }
            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Miecz"))
                swordEq.Visible = true;
            else swordEq.Visible = false;

            if (game.CheckPlayerInventory("Łuk"))
                bowEq.Visible = true;
            else bowEq.Visible = false;

            if (game.CheckPlayerInventory("Buława"))
                maceEq.Visible = true;
            else maceEq.Visible = false;

            if (game.CheckPlayerInventory("Czerwona mikstura"))
                potionRedEq.Visible = true;
            else potionRedEq.Visible = false;

            if (game.CheckPlayerInventory("Niebieska mikstura"))
                potionBlueEq.Visible = true;
            else potionBlueEq.Visible = false;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Zostałeś zabity!");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
    }
}
