namespace OPR_Projekt
{
    partial class MainGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            labelStats = new Label();
            labelZivljenje = new Label();
            labelOrozje = new Label();
            comboBoxOrozje = new ComboBox();
            labelRazred = new Label();
            panel1 = new Panel();
            gumbShop = new Button();
            comboBoxDodatno2 = new ComboBox();
            labelDodatno2 = new Label();
            comboBoxDodatno = new ComboBox();
            labelDodatno = new Label();
            gumbHeal = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            labelEnemyŽivljenje = new Label();
            gumbFlee = new Button();
            gumbAttack = new Button();
            pictureBoxPlayer = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxEnemy1 = new PictureBox();
            pictureBoxEnemy2 = new PictureBox();
            pictureBoxEnemy3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy3).BeginInit();
            SuspendLayout();
            // 
            // labelStats
            // 
            labelStats.AutoSize = true;
            labelStats.Font = new Font("Arial Black", 22F, FontStyle.Bold);
            labelStats.Location = new Point(0, 0);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(103, 42);
            labelStats.TabIndex = 0;
            labelStats.Text = "Stats";
            // 
            // labelZivljenje
            // 
            labelZivljenje.AutoSize = true;
            labelZivljenje.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelZivljenje.Location = new Point(3, 53);
            labelZivljenje.Name = "labelZivljenje";
            labelZivljenje.Size = new Size(68, 22);
            labelZivljenje.TabIndex = 2;
            labelZivljenje.Text = "Življenje";
            // 
            // labelOrozje
            // 
            labelOrozje.AutoSize = true;
            labelOrozje.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelOrozje.Location = new Point(3, 72);
            labelOrozje.Name = "labelOrozje";
            labelOrozje.Size = new Size(71, 22);
            labelOrozje.TabIndex = 3;
            labelOrozje.Text = "Weapon:";
            // 
            // comboBoxOrozje
            // 
            comboBoxOrozje.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrozje.FormattingEnabled = true;
            comboBoxOrozje.Location = new Point(7, 94);
            comboBoxOrozje.Name = "comboBoxOrozje";
            comboBoxOrozje.Size = new Size(98, 23);
            comboBoxOrozje.TabIndex = 4;
            comboBoxOrozje.TabStop = false;
            // 
            // labelRazred
            // 
            labelRazred.AutoSize = true;
            labelRazred.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelRazred.Location = new Point(3, 34);
            labelRazred.Name = "labelRazred";
            labelRazred.Size = new Size(58, 22);
            labelRazred.TabIndex = 1;
            labelRazred.Text = "Razred";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(gumbShop);
            panel1.Controls.Add(comboBoxDodatno2);
            panel1.Controls.Add(labelDodatno2);
            panel1.Controls.Add(comboBoxDodatno);
            panel1.Controls.Add(labelDodatno);
            panel1.Controls.Add(labelStats);
            panel1.Controls.Add(gumbHeal);
            panel1.Controls.Add(comboBoxOrozje);
            panel1.Controls.Add(labelRazred);
            panel1.Controls.Add(labelOrozje);
            panel1.Controls.Add(labelZivljenje);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 379);
            panel1.TabIndex = 6;
            // 
            // gumbShop
            // 
            gumbShop.BackColor = Color.FromArgb(255, 255, 192);
            gumbShop.Cursor = Cursors.Hand;
            gumbShop.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            gumbShop.Location = new Point(3, 284);
            gumbShop.Name = "gumbShop";
            gumbShop.Size = new Size(160, 52);
            gumbShop.TabIndex = 13;
            gumbShop.Text = "Shop";
            gumbShop.UseVisualStyleBackColor = false;
            gumbShop.Click += gumbShop_Click;
            // 
            // comboBoxDodatno2
            // 
            comboBoxDodatno2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDodatno2.FormattingEnabled = true;
            comboBoxDodatno2.Location = new Point(7, 188);
            comboBoxDodatno2.Name = "comboBoxDodatno2";
            comboBoxDodatno2.Size = new Size(114, 23);
            comboBoxDodatno2.TabIndex = 9;
            comboBoxDodatno2.TabStop = false;
            // 
            // labelDodatno2
            // 
            labelDodatno2.AutoSize = true;
            labelDodatno2.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            labelDodatno2.Location = new Point(7, 166);
            labelDodatno2.Name = "labelDodatno2";
            labelDodatno2.Size = new Size(51, 22);
            labelDodatno2.TabIndex = 8;
            labelDodatno2.Text = "label1";
            // 
            // comboBoxDodatno
            // 
            comboBoxDodatno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDodatno.FormattingEnabled = true;
            comboBoxDodatno.Location = new Point(7, 141);
            comboBoxDodatno.Name = "comboBoxDodatno";
            comboBoxDodatno.Size = new Size(98, 23);
            comboBoxDodatno.TabIndex = 7;
            comboBoxDodatno.TabStop = false;
            // 
            // labelDodatno
            // 
            labelDodatno.AutoSize = true;
            labelDodatno.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold);
            labelDodatno.Location = new Point(7, 119);
            labelDodatno.Name = "labelDodatno";
            labelDodatno.Size = new Size(51, 22);
            labelDodatno.TabIndex = 6;
            labelDodatno.Text = "label1";
            // 
            // gumbHeal
            // 
            gumbHeal.BackColor = Color.FromArgb(192, 255, 192);
            gumbHeal.Cursor = Cursors.Hand;
            gumbHeal.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            gumbHeal.Location = new Point(3, 215);
            gumbHeal.Name = "gumbHeal";
            gumbHeal.Size = new Size(160, 52);
            gumbHeal.TabIndex = 8;
            gumbHeal.Text = "Heal";
            gumbHeal.UseVisualStyleBackColor = false;
            gumbHeal.Click += gumbHeal_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(gumbFlee);
            panel2.Controls.Add(gumbAttack);
            panel2.Location = new Point(3, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(1531, 148);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(labelEnemyŽivljenje);
            panel3.Location = new Point(16, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 41);
            panel3.TabIndex = 3;
            // 
            // labelEnemyŽivljenje
            // 
            labelEnemyŽivljenje.AutoSize = true;
            labelEnemyŽivljenje.BackColor = Color.Lavender;
            labelEnemyŽivljenje.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelEnemyŽivljenje.Location = new Point(53, 3);
            labelEnemyŽivljenje.Name = "labelEnemyŽivljenje";
            labelEnemyŽivljenje.Size = new Size(52, 33);
            labelEnemyŽivljenje.TabIndex = 2;
            labelEnemyŽivljenje.Text = "HP";
            // 
            // gumbFlee
            // 
            gumbFlee.BackColor = Color.FromArgb(192, 255, 192);
            gumbFlee.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            gumbFlee.ForeColor = Color.FromArgb(0, 64, 0);
            gumbFlee.Location = new Point(1036, 20);
            gumbFlee.Name = "gumbFlee";
            gumbFlee.Size = new Size(134, 48);
            gumbFlee.TabIndex = 1;
            gumbFlee.Text = "Flee";
            gumbFlee.UseVisualStyleBackColor = false;
            gumbFlee.Click += gumbFlee_Click;
            // 
            // gumbAttack
            // 
            gumbAttack.BackColor = Color.FromArgb(255, 192, 192);
            gumbAttack.Font = new Font("Arial Black", 16F, FontStyle.Bold);
            gumbAttack.ForeColor = Color.FromArgb(64, 0, 0);
            gumbAttack.Location = new Point(1036, 81);
            gumbAttack.Name = "gumbAttack";
            gumbAttack.Size = new Size(134, 48);
            gumbAttack.TabIndex = 0;
            gumbAttack.Text = "Attack";
            gumbAttack.UseVisualStyleBackColor = false;
            gumbAttack.Click += gumbAttack_Click;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackColor = Color.Transparent;
            pictureBoxPlayer.BackgroundImageLayout = ImageLayout.None;
            pictureBoxPlayer.Image = (Image)resources.GetObject("pictureBoxPlayer.Image");
            pictureBoxPlayer.Location = new Point(205, 248);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(60, 60);
            pictureBoxPlayer.TabIndex = 9;
            pictureBoxPlayer.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxEnemy1
            // 
            pictureBoxEnemy1.BackColor = Color.Transparent;
            pictureBoxEnemy1.BackgroundImageLayout = ImageLayout.None;
            pictureBoxEnemy1.Image = (Image)resources.GetObject("pictureBoxEnemy1.Image");
            pictureBoxEnemy1.Location = new Point(683, 27);
            pictureBoxEnemy1.Name = "pictureBoxEnemy1";
            pictureBoxEnemy1.Size = new Size(60, 60);
            pictureBoxEnemy1.TabIndex = 10;
            pictureBoxEnemy1.TabStop = false;
            // 
            // pictureBoxEnemy2
            // 
            pictureBoxEnemy2.BackColor = Color.Transparent;
            pictureBoxEnemy2.Image = (Image)resources.GetObject("pictureBoxEnemy2.Image");
            pictureBoxEnemy2.Location = new Point(736, 248);
            pictureBoxEnemy2.Name = "pictureBoxEnemy2";
            pictureBoxEnemy2.Size = new Size(60, 60);
            pictureBoxEnemy2.TabIndex = 11;
            pictureBoxEnemy2.TabStop = false;
            // 
            // pictureBoxEnemy3
            // 
            pictureBoxEnemy3.BackColor = Color.Transparent;
            pictureBoxEnemy3.Image = (Image)resources.GetObject("pictureBoxEnemy3.Image");
            pictureBoxEnemy3.Location = new Point(973, 130);
            pictureBoxEnemy3.Name = "pictureBoxEnemy3";
            pictureBoxEnemy3.Size = new Size(60, 60);
            pictureBoxEnemy3.TabIndex = 12;
            pictureBoxEnemy3.TabStop = false;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1191, 528);
            Controls.Add(pictureBoxEnemy3);
            Controls.Add(pictureBoxEnemy2);
            Controls.Add(pictureBoxEnemy1);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainGame";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStats;
        private Label labelZivljenje;
        private Label labelOrozje;
        private ComboBox comboBoxOrozje;
        private Label labelRazred;
        private Panel panel1;
        private Label labelDodatno;
        private ComboBox comboBoxDodatno;
        private Label labelDodatno2;
        private ComboBox comboBoxDodatno2;
        private Panel panel2;
        private Button gumbHeal;
        private PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxEnemy1;
        private PictureBox pictureBoxEnemy2;
        private PictureBox pictureBoxEnemy3;
        private Button gumbShop;
        private Button gumbAttack;
        private Button gumbFlee;
        private Panel panel3;
        private Label labelEnemyŽivljenje;
    }
}