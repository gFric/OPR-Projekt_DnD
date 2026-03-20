using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player_ns;
using Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OPR_Projekt
{
    public partial class MainGame : Form
    {
        private Player igralec;
        private PictureBox[] enemyPictures;
        private Enemy[] enemies;
        private int currentEnemyIndex = -1;
        private bool inCombat = false;
        private Enemy currentEnemy;
        private int štPogovorov = 0;
        private int štMrtvihEnemyjov;

        private void InitGame()
        {
            this.KeyPreview = true;
            this.KeyDown += MainGame_KeyDown;
            this.KeyUp += MainGame_KeyUp;


            panel2.Visible = false;

            enemyPictures = new PictureBox[]
            {
                pictureBoxEnemy1,
                pictureBoxEnemy2,
                pictureBoxEnemy3
            };

            enemies = new Enemy[]
            {
                new Enemy(75, 25, 0),
                new Enemy(85, 30, 1),
                new Enemy(120, 50, 2)
            };

            timer1.Interval = 16;
            timer1.Start();

        }

        public MainGame()
        {
            InitializeComponent();
            InitGame();
        }


        public MainGame(Player igralec)
        {
            InitializeComponent();
            this.igralec = igralec;
            this.igralec.OnAttack += Igralec_OnAttack;
            PrikažiStatistiko();
            NaložiComboBox();
            InitGame();
        }



        //satistika
        private void PrikažiStatistiko()
        {
            labelRazred.Text = $"Class: {igralec.ImeRazreda}";
            labelZivljenje.Text = $"Health: {igralec.Življenje}";
            labelDodatno.Text = igralec.DrugoOrožje;
            if (igralec is Wizard wizard)
            {
                labelDodatno.Text = wizard.WizardSpell1;
                labelDodatno2.Text = wizard.WizardSpell2;
            }
            gumbHeal.Text = $"Heal ({igralec.ŠtHealov})";
        }



        //comboBox na začetki
        private void NaložiComboBox()
        {
            labelDodatno2.Visible = false;
            comboBoxDodatno2.Visible = false;

            if (igralec is Ranger ranger)
            {
                comboBoxOrozje.Items.Add(ranger.VrstaLoka[0]);
                comboBoxOrozje.SelectedItem = ranger.VrstaLoka[0];

                comboBoxDodatno.Items.Add(ranger.VrstaPuščice[0]);
                comboBoxDodatno.SelectedItem = ranger.VrstaPuščice[0];
            }
            else if (igralec is Fighter fighter)
            {
                comboBoxOrozje.Items.Add(fighter.VrstaMeča[0]);
                comboBoxOrozje.SelectedItem = fighter.VrstaMeča[0];

                comboBoxDodatno.Items.Add(fighter.VrstaŠčita[0]);
                comboBoxDodatno.SelectedItem = fighter.VrstaŠčita[0];
            }
            else if (igralec is Wizard wizard)
            {
                labelDodatno2.Visible = true;
                comboBoxDodatno2.Visible = true;

                comboBoxOrozje.Items.Add(wizard.VrstaPalice[0]);
                comboBoxOrozje.SelectedItem = wizard.VrstaPalice[0];

                comboBoxDodatno.Items.Add(wizard.VrstaDamageSpells[0]);
                comboBoxDodatno.SelectedItem = wizard.VrstaDamageSpells[0];

                comboBoxDodatno2.Items.Add(wizard.VrstaProtectionSpells[0]);
                comboBoxDodatno2.SelectedItem = wizard.VrstaProtectionSpells[0];
            }
        }

        private void NaložiOrožja()
        {
            comboBoxOrozje.Items.Clear();
            comboBoxDodatno.Items.Clear();
            comboBoxDodatno2.Items.Clear();

            if (igralec is Wizard wizard)
            {
                for (int i = 0; i <= wizard.LevelPalice; i++)
                {
                    comboBoxOrozje.Items.Add(wizard.VrstaPalice[i]);
                }
                comboBoxOrozje.SelectedIndex = wizard.SelectedPalica;

                for (int i = 0; i <= wizard.LevelDamageSpell; i++)
                {
                    comboBoxDodatno.Items.Add(wizard.VrstaDamageSpells[i]);
                }
                comboBoxDodatno.SelectedIndex = wizard.SelectedDamageSpell;

                for (int i = 0; i <= wizard.LevelProtectionSpell; i++)
                {
                    comboBoxDodatno2.Items.Add(wizard.VrstaProtectionSpells[i]);
                }
                comboBoxDodatno2.SelectedIndex = wizard.SelectedProtectionSpell;

                comboBoxDodatno2.Visible = true;
                labelDodatno2.Visible = true;
            }

            else if (igralec is Ranger ranger)
            {
                for (int i = 0; i <= ranger.LevelLoka; i++)
                {
                    comboBoxOrozje.Items.Add(ranger.VrstaLoka[i]);
                }
                comboBoxOrozje.SelectedIndex = ranger.SelectedLok;

                for (int i = 0; i <= ranger.LevelPuščice; i++)
                {
                    comboBoxDodatno.Items.Add(ranger.VrstaPuščice[i]);
                }
                comboBoxDodatno.SelectedIndex = ranger.SelectedPuščica;

                comboBoxDodatno2.Visible = false;
                labelDodatno2.Visible = false;
            }

            else if (igralec is Fighter fighter)
            {
                for (int i = 0; i <= fighter.LevelMeča; i++)
                {
                    comboBoxOrozje.Items.Add(fighter.VrstaMeča[i]);
                }
                comboBoxOrozje.SelectedIndex = fighter.SelectedMeč;

                for (int i = 0; i <= fighter.LevelŠčita; i++)
                {
                    comboBoxDodatno.Items.Add(fighter.VrstaŠčita[i]);
                }
                comboBoxDodatno.SelectedIndex = fighter.SelectedŠčit;

                comboBoxDodatno2.Visible = false;
                labelDodatno2.Visible = false;
            }
        }


        //premikanje
        bool gor, dol, levo, desno;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hitrost = 7;
            Point pozicija = pictureBoxPlayer.Location;

            if (gor) pozicija.Y -= hitrost;
            if (dol) pozicija.Y += hitrost;
            if (levo) pozicija.X -= hitrost;
            if (desno) pozicija.X += hitrost;

            int leviRob = 180;
            int spodnjiRob = 168;

            pozicija.X = Math.Max(leviRob, Math.Min(ClientSize.Width - pictureBoxPlayer.Width, pozicija.X));

            pozicija.Y = Math.Max(0, Math.Min(ClientSize.Height - pictureBoxPlayer.Height - spodnjiRob, pozicija.Y));

            pictureBoxPlayer.Location = pozicija;

            if (inCombat)
            {
                return;
            }
            else
            {
                for (int i = 0; i < enemyPictures.Length; i++)
                {
                    if (enemies[i] != null && enemyPictures[i].Visible && pictureBoxPlayer.Bounds.IntersectsWith(enemyPictures[i].Bounds))
                    {
                        StartCombat(i);
                        break;
                    }
                }
            }
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) gor = true;
            if (e.KeyCode == Keys.S) dol = true;
            if (e.KeyCode == Keys.A) levo = true;
            if (e.KeyCode == Keys.D) desno = true;
        }

        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) gor = false;
            if (e.KeyCode == Keys.S) dol = false;
            if (e.KeyCode == Keys.A) levo = false;
            if (e.KeyCode == Keys.D) desno = false;
        }



        //start pa end combat
        private void StartCombat(int index)
        {
            inCombat = true;
            currentEnemyIndex = index;
            currentEnemy = enemies[index];
            panel2.Visible = true;
            gor = dol = levo = desno = false;
            labelEnemyŽivljenje.Text = currentEnemy.Življenje.ToString();
            StartDialog(currentEnemy);
        }

        private void EndCombat()
        {
            panel2.Visible = false;
            inCombat = false;
            currentEnemyIndex = -1;
        }

        private void Igralec_OnAttack(int damage)
        {
            if (currentEnemy == null) { return; }

            labelEnemyŽivljenje.Text = currentEnemy.Življenje.ToString();

            if (currentEnemy.IsDead)
            {
                enemyPictures[currentEnemyIndex].Visible = false;
                igralec.Coins += 25;
                igralec.ŠtHealov++;
                štPogovorov = 0;
                PrikažiStatistiko();
                EndCombat();

                if (enemies[0].IsDead && enemies[1].IsDead && enemies[2].IsDead)
                {
                    MessageBox.Show("Congratulations! You have successfully saved the kingdom from evil!");
                    Application.Exit();
                }

                return;
            }

            currentEnemy.AttackBack(igralec);
            PrikažiStatistiko();

            if (igralec.Življenje <= 0)
            {
                MessageBox.Show("You died!");
                Application.Exit();
                return;
            }

            EndCombat();
        }


        //gumbi
        private void gumbAttack_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return;

            štPogovorov++;
            StartDialog(currentEnemy);

            if (igralec is Wizard wizard)
            {
                wizard.SelectedPalica = comboBoxOrozje.SelectedIndex;
                wizard.SelectedDamageSpell = comboBoxDodatno.SelectedIndex;
            }
            else if (igralec is Ranger ranger)
            {
                ranger.SelectedLok = comboBoxOrozje.SelectedIndex;
                ranger.SelectedPuščica = comboBoxDodatno.SelectedIndex;
            }
            else if (igralec is Fighter fighter)
            {
                fighter.SelectedMeč = comboBoxOrozje.SelectedIndex;
                fighter.SelectedŠčit = comboBoxDodatno.SelectedIndex;
            }

            igralec.Attack(currentEnemy);
        }


        private void gumbFlee_Click(object sender, EventArgs e)
        {
            EndCombat();
        }

        private void gumbHeal_Click(object sender, EventArgs e)
        {
            if (igralec.ŠtHealov > 0)
            {
                igralec.Heal(20);
                if (igralec.Življenje < 100)
                {
                    MessageBox.Show("You have healed yourseft for 20 health");
                }
                else if (igralec.Življenje == 100)
                {
                    MessageBox.Show("You have overhealed yourseft to 100 health. You can not go further");
                }
            }
            else
            {
                MessageBox.Show("You have no heals left");
            }
            PrikažiStatistiko();
        }

        private void gumbShop_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(igralec, this);
            shop.ShowDialog();
            NaložiOrožja();
        }

        public void StartDialog(Enemy enemy)
        {
            textBoxBesedilo.Text = currentEnemy[currentEnemy.Id, igralec, štPogovorov].ToString();
        }
    }
}
