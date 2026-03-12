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

namespace OPR_Projekt
{
    public partial class MainGame : Form
    {
        private PictureBox[] enemyPictures;
        private Enemy[] enemies;
        private int currentEnemyIndex = -1;
        private bool inCombat = false;
        private Enemy currentEnemy;

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
                new Enemy(50, 10),
                new Enemy(70, 15),
                new Enemy(100, 20)
            };

            timer1.Interval = 16;
            timer1.Start();
        }

        public MainGame()
        {
            InitializeComponent();
            InitGame();
        }

        private Player igralec;

        public MainGame(Player igralec)
        {
            InitializeComponent();
            this.igralec = igralec;
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
                    if (enemyPictures[i].Visible && pictureBoxPlayer.Bounds.IntersectsWith(enemyPictures[i].Bounds))
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
        }

        private void EndCombat()
        {
            panel2.Visible = false;
            inCombat = false;
            currentEnemy = null;
            currentEnemyIndex = -1;
        }



        //gumbi
        private void gumbAttack_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null)
            {
                return;
            }
            else
            {
                igralec.Attack(currentEnemy);
            }

            if (currentEnemy.IsDead == false)
            {
                currentEnemy.AttackBack(igralec);
            }
            else
            {
                enemyPictures[currentEnemyIndex].Visible = false;
                EndCombat();
            }

            PrikažiStatistiko();
        }

        private void gumbFlee_Click(object sender, EventArgs e)
        {
            EndCombat();
        }

        private void gumbHeal_Click(object sender, EventArgs e)
        {
            igralec.Heal(20);
            PrikažiStatistiko();
        }

        private void comboBoxOrozje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
