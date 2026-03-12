using System;
using System.Numerics;
using static OPR_Projekt.MainGame;
using Player_ns;

namespace OPR_Projekt
{
    public partial class ChooseAClass : Form
    {
        
        public ChooseAClass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gumbRanger_Click(object sender, EventArgs e)
        {
            OdpriStatistiko(new Ranger());
        }

        private void gumbFighter_Click(object sender, EventArgs e)
        {
            OdpriStatistiko(new Fighter());
        }

        private void gumbWizard_Click(object sender, EventArgs e)
        {
            OdpriStatistiko(new Wizard());
        }

        private void OdpriStatistiko(Player igralec)
        {
            MainGame mainGame = new MainGame(igralec);
            mainGame.Show();
            this.Hide();
        }
    }
}
