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
    public partial class Shop : Form
    {
        private Player igralec;

        private MainGame mainGame;

        public Shop(Player igralec1, MainGame game)
        {
            InitializeComponent();
            igralec = igralec1;
            this.TopMost = true;
            mainGame = game;
            panelSpell2.Visible = false;
            NastaviShop();
            label_štCoins.Text = igralec.Coins.ToString();
            gumbUpgradeWeapon.Text = igralec.item1_cena.ToString();
            gumbUpgradeDrugaStvar.Text = igralec.item2_cena.ToString();
            gumbUpgradeDrugiSpell.Text = igralec.item3_cena.ToString();
            PreveriZaMaxLevel();
        }

        public void NastaviShop()
        {
            if (igralec is Ranger)
            {
                labelUpgradeWeapon.Text = "Bow:";
                labelDrugaStvar.Text = "Arrows:";
            }
            else if (igralec is Fighter)
            {
                labelUpgradeWeapon.Text = "Sword:";
                labelDrugaStvar.Text = "Shield:";
            }
            else if (igralec is Wizard wizard)
            {
                panelSpell2.Visible = true;
                labelUpgradeWeapon.Text = "Wand:";
                labelDrugaStvar.Text = "Damage Spell:";
            }
        }

        private void gumbUpgradeWeapon_Click(object sender, EventArgs e)
        {
            if (igralec is Wizard wizard)
            {
                if (wizard.LevelPalice < wizard.VrstaPalice.Length - 1)
                {
                    if (igralec.Coins >= igralec.item1_cena)
                    {
                        igralec.Coins -= igralec.item1_cena;
                        wizard.LevelPalice++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item1_cena += 25;
                        gumbUpgradeWeapon.Text = igralec.item1_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }
            else if (igralec is Ranger ranger)
            {
                if (ranger.LevelLoka < ranger.VrstaLoka.Length - 1)
                {
                    if (igralec.Coins >= igralec.item1_cena)
                    {
                        igralec.Coins -= igralec.item1_cena;
                        ranger.LevelLoka++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item1_cena += 25;
                        gumbUpgradeWeapon.Text = igralec.item1_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }
            else if (igralec is Fighter fighter)
            {
                if (fighter.LevelMeča < fighter.VrstaMeča.Length - 1)
                {
                    if (igralec.Coins >= igralec.item1_cena)
                    {
                        igralec.Coins -= igralec.item1_cena;
                        fighter.LevelMeča++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item1_cena += 25;
                        gumbUpgradeWeapon.Text = igralec.item1_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }

            PreveriZaMaxLevel();
        }

        private void gumbUpgradeDrugaStvar_Click(object sender, EventArgs e)
        {
            if (igralec is Wizard wizard)
            {
                if (wizard.LevelDamageSpell < wizard.VrstaDamageSpells.Length - 1)
                {
                    if (igralec.Coins >= igralec.item2_cena)
                    {
                        igralec.Coins -= igralec.item2_cena;
                        wizard.LevelDamageSpell++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item2_cena += 25;
                        gumbUpgradeDrugaStvar.Text = igralec.item2_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }
            else if (igralec is Ranger ranger)
            {
                if (ranger.LevelPuščice < ranger.VrstaPuščice.Length - 1)
                {
                    if (igralec.Coins >= igralec.item2_cena)
                    {
                        igralec.Coins -= igralec.item2_cena;
                        ranger.LevelPuščice++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item2_cena += 25;
                        gumbUpgradeDrugaStvar.Text = igralec.item2_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }
            else if (igralec is Fighter fighter)
            {
                if (fighter.LevelŠčita < fighter.VrstaŠčita.Length - 1)
                {
                    if (igralec.Coins >= igralec.item2_cena)
                    {
                        igralec.Coins -= igralec.item2_cena;
                        fighter.LevelŠčita++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item2_cena += 25;
                        gumbUpgradeDrugaStvar.Text = igralec.item2_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }

            PreveriZaMaxLevel();
        }

        private void gumbUpgradeDrugiSpell_Click(object sender, EventArgs e)
        {
            if (igralec is Wizard wizard)
            {
                if (wizard.LevelProtectionSpell < wizard.VrstaProtectionSpells.Length - 1)
                {
                    if (igralec.Coins >= igralec.item3_cena)
                    {
                        igralec.Coins -= igralec.item3_cena;
                        wizard.LevelProtectionSpell++;

                        label_štCoins.Text = igralec.Coins.ToString();

                        igralec.item3_cena += 25;
                        gumbUpgradeDrugiSpell.Text = igralec.item3_cena.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not enough coins!");
                    }
                }
                else
                {
                    MessageBox.Show("Max level reached!");
                }
            }

            PreveriZaMaxLevel();
        }

        public void PreveriZaMaxLevel()
        {
            if (igralec.item1_cena >= 75)
            {
                gumbUpgradeWeapon.Text = "MAX LEVEL";
            }
            else if (igralec.item2_cena >= 75)
            {
                gumbUpgradeDrugaStvar.Text = "MAX LEVEL";
            }
            else if (igralec.item3_cena >= 75)
            {
                gumbUpgradeDrugiSpell.Text = "MAX LEVEL";
            }
        }
    }
}
