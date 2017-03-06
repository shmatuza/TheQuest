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
            this.KeyPreview = true;
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

                groupBox2.Text = "Atak";
                upAttackButton.Text = "W";
                upAttackButton.Width = 23;
                upAttackButton.Location = new Point(35, 16);
                leftAttackButton.Visible = true;
                rightAttackButton.Visible = true;
                downAttackButton.Visible = true;  
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

                groupBox2.Text = "Atak";
                upAttackButton.Text = "W";
                upAttackButton.Width = 23;
                upAttackButton.Location = new Point(35, 16);
                leftAttackButton.Visible = true;
                rightAttackButton.Visible = true;
                downAttackButton.Visible = true;
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

                groupBox2.Text = "Atak";
                upAttackButton.Text = "W";
                upAttackButton.Width = 23;
                upAttackButton.Location = new Point(35, 16);
                leftAttackButton.Visible = true;
                rightAttackButton.Visible = true;
                downAttackButton.Visible = true;
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

                groupBox2.Text = "Użyj mikstury!";
                upAttackButton.Text = "W";
                upAttackButton.Width = 60;
                upAttackButton.Location = new Point(15, 28);
                leftAttackButton.Visible = false;
                rightAttackButton.Visible = false;
                downAttackButton.Visible = false;

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

                groupBox2.Text = "Użyj mikstury";
                upAttackButton.Text = "W";
                upAttackButton.Width = 60;
                upAttackButton.Location = new Point(15, 28);
                leftAttackButton.Visible = false;
                rightAttackButton.Visible = false;
                downAttackButton.Visible = false;
            }
        }

        private void UpdateCharacters()
        {
            playerPicture.Visible = Visible;
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
            {
                label2.Text = "Nietoperz";
                bat.Visible = true;
            }
            else
            {
                bat.Visible = false;
                label2.Text = "";
                batHitPoints.Text = "";
            }

            if (showGhost == true)
            {
                label3.Text = "Duch";
                ghost.Visible = true;
            }
            else
            {
                ghost.Visible = false;
                label3.Text = "";
                ghostHitPoints.Text = "";
            }

            if (showGhoul == true)
            {
                ghoul.Visible = true;
                label4.Text = "Upiór";
            }
            else
            {
                ghoul.Visible = false;
                label4.Text = "";
                ghoulHitPoints.Text = "";
            }

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
                timer1.Enabled = false;
                MessageBox.Show("Zostałeś zabity!");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                timer1.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        game.MovePlayer(Direction.Up);
                        UpdateCharacters();
                        break;
                    }
                case Keys.Down:
                    {
                        game.MovePlayer(Direction.Down);
                        UpdateCharacters();
                        break;
                    }
                case Keys.Left:
                    {
                        game.MovePlayer(Direction.Left);
                        UpdateCharacters();
                        break;
                    }
                case Keys.Right:
                    {
                        game.MovePlayer(Direction.Right);
                        UpdateCharacters();
                        break;
                    }
                case Keys.W:
                    {
                        game.Attack(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.S:
                    {
                        game.Attack(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.A:
                    {
                        game.Attack(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.D:
                    {
                        game.Attack(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    }     
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            game.MoveEnemy(random);
            UpdateCharacters();
        }
    }
}
