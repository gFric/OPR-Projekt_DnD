namespace OPR_Projekt
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCoins = new Label();
            label_štCoins = new Label();
            panel1 = new Panel();
            gumbUpgradeWeapon = new Button();
            labelUpgrades = new Label();
            panel2 = new Panel();
            panelSpell2 = new Panel();
            gumbUpgradeDrugiSpell = new Button();
            labelSpell2 = new Label();
            labelDrugaStvar = new Label();
            gumbUpgradeDrugaStvar = new Button();
            labelUpgradeWeapon = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelSpell2.SuspendLayout();
            SuspendLayout();
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            labelCoins.Location = new Point(3, 10);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(109, 38);
            labelCoins.TabIndex = 0;
            labelCoins.Text = "Coins:";
            // 
            // label_štCoins
            // 
            label_štCoins.AutoSize = true;
            label_štCoins.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label_štCoins.Location = new Point(114, 10);
            label_štCoins.Name = "label_štCoins";
            label_štCoins.Size = new Size(35, 38);
            label_štCoins.TabIndex = 1;
            label_štCoins.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(labelCoins);
            panel1.Controls.Add(label_štCoins);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 63);
            panel1.TabIndex = 2;
            // 
            // gumbUpgradeWeapon
            // 
            gumbUpgradeWeapon.BackColor = Color.Khaki;
            gumbUpgradeWeapon.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            gumbUpgradeWeapon.Location = new Point(13, 66);
            gumbUpgradeWeapon.Name = "gumbUpgradeWeapon";
            gumbUpgradeWeapon.Size = new Size(96, 51);
            gumbUpgradeWeapon.TabIndex = 3;
            gumbUpgradeWeapon.Text = "button1";
            gumbUpgradeWeapon.UseVisualStyleBackColor = false;
            gumbUpgradeWeapon.Click += gumbUpgradeWeapon_Click;
            // 
            // labelUpgrades
            // 
            labelUpgrades.AutoSize = true;
            labelUpgrades.Font = new Font("Arial Black", 15F, FontStyle.Bold);
            labelUpgrades.Location = new Point(3, 0);
            labelUpgrades.Name = "labelUpgrades";
            labelUpgrades.Size = new Size(122, 28);
            labelUpgrades.TabIndex = 5;
            labelUpgrades.Text = "Upgrades:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(panelSpell2);
            panel2.Controls.Add(labelDrugaStvar);
            panel2.Controls.Add(gumbUpgradeDrugaStvar);
            panel2.Controls.Add(labelUpgradeWeapon);
            panel2.Controls.Add(labelUpgrades);
            panel2.Controls.Add(gumbUpgradeWeapon);
            panel2.Location = new Point(-1, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 141);
            panel2.TabIndex = 6;
            // 
            // panelSpell2
            // 
            panelSpell2.Controls.Add(gumbUpgradeDrugiSpell);
            panelSpell2.Controls.Add(labelSpell2);
            panelSpell2.Location = new Point(281, 27);
            panelSpell2.Name = "panelSpell2";
            panelSpell2.Size = new Size(200, 100);
            panelSpell2.TabIndex = 11;
            // 
            // gumbUpgradeDrugiSpell
            // 
            gumbUpgradeDrugiSpell.BackColor = Color.Khaki;
            gumbUpgradeDrugiSpell.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            gumbUpgradeDrugiSpell.Location = new Point(3, 39);
            gumbUpgradeDrugiSpell.Name = "gumbUpgradeDrugiSpell";
            gumbUpgradeDrugiSpell.Size = new Size(96, 51);
            gumbUpgradeDrugiSpell.TabIndex = 9;
            gumbUpgradeDrugiSpell.Text = "button2";
            gumbUpgradeDrugiSpell.UseVisualStyleBackColor = false;
            gumbUpgradeDrugiSpell.Click += gumbUpgradeDrugiSpell_Click;
            // 
            // labelSpell2
            // 
            labelSpell2.AutoSize = true;
            labelSpell2.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            labelSpell2.Location = new Point(0, 19);
            labelSpell2.Name = "labelSpell2";
            labelSpell2.Size = new Size(130, 19);
            labelSpell2.TabIndex = 10;
            labelSpell2.Text = "Protection Spell";
            // 
            // labelDrugaStvar
            // 
            labelDrugaStvar.AutoSize = true;
            labelDrugaStvar.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            labelDrugaStvar.Location = new Point(149, 46);
            labelDrugaStvar.Name = "labelDrugaStvar";
            labelDrugaStvar.Size = new Size(98, 19);
            labelDrugaStvar.TabIndex = 8;
            labelDrugaStvar.Text = "Druga Stvar";
            // 
            // gumbUpgradeDrugaStvar
            // 
            gumbUpgradeDrugaStvar.BackColor = Color.Khaki;
            gumbUpgradeDrugaStvar.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            gumbUpgradeDrugaStvar.Location = new Point(151, 66);
            gumbUpgradeDrugaStvar.Name = "gumbUpgradeDrugaStvar";
            gumbUpgradeDrugaStvar.Size = new Size(96, 51);
            gumbUpgradeDrugaStvar.TabIndex = 7;
            gumbUpgradeDrugaStvar.Text = "button1";
            gumbUpgradeDrugaStvar.UseVisualStyleBackColor = false;
            gumbUpgradeDrugaStvar.Click += gumbUpgradeDrugaStvar_Click;
            // 
            // labelUpgradeWeapon
            // 
            labelUpgradeWeapon.AutoSize = true;
            labelUpgradeWeapon.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            labelUpgradeWeapon.Location = new Point(13, 46);
            labelUpgradeWeapon.Name = "labelUpgradeWeapon";
            labelUpgradeWeapon.Size = new Size(68, 19);
            labelUpgradeWeapon.TabIndex = 6;
            labelUpgradeWeapon.Text = "Weapon";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(425, 236);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Shop";
            Text = "Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSpell2.ResumeLayout(false);
            panelSpell2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCoins;
        private Label label_štCoins;
        private Panel panel1;
        private Button gumbUpgradeWeapon;
        private Label labelUpgrades;
        private Panel panel2;
        private Label labelUpgradeWeapon;
        private Label labelDrugaStvar;
        private Button gumbUpgradeDrugaStvar;
        private Label labelSpell2;
        private Button gumbUpgradeDrugiSpell;
        private Panel panelSpell2;
    }
}