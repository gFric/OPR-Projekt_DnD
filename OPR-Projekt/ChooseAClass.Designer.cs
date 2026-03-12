namespace OPR_Projekt
{
    partial class ChooseAClass
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gumbRanger = new Button();
            gumbFighter = new Button();
            gumbWizard = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 30.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(442, 58);
            label1.TabIndex = 0;
            label1.Text = "Choose Your Class";
            // 
            // gumbRanger
            // 
            gumbRanger.BackColor = Color.FromArgb(192, 255, 192);
            gumbRanger.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            gumbRanger.Location = new Point(23, 169);
            gumbRanger.Name = "gumbRanger";
            gumbRanger.Size = new Size(109, 49);
            gumbRanger.TabIndex = 1;
            gumbRanger.Text = "Ranger";
            gumbRanger.UseVisualStyleBackColor = false;
            gumbRanger.Click += gumbRanger_Click;
            // 
            // gumbFighter
            // 
            gumbFighter.BackColor = Color.FromArgb(255, 192, 192);
            gumbFighter.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            gumbFighter.Location = new Point(197, 169);
            gumbFighter.Name = "gumbFighter";
            gumbFighter.Size = new Size(109, 49);
            gumbFighter.TabIndex = 2;
            gumbFighter.Text = "Fighter";
            gumbFighter.UseVisualStyleBackColor = false;
            gumbFighter.Click += gumbFighter_Click;
            // 
            // gumbWizard
            // 
            gumbWizard.BackColor = Color.FromArgb(192, 192, 255);
            gumbWizard.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            gumbWizard.Location = new Point(370, 169);
            gumbWizard.Name = "gumbWizard";
            gumbWizard.Size = new Size(109, 49);
            gumbWizard.TabIndex = 3;
            gumbWizard.Text = "Wizard";
            gumbWizard.UseVisualStyleBackColor = false;
            gumbWizard.Click += gumbWizard_Click;
            // 
            // ChooseAClass
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 316);
            Controls.Add(gumbWizard);
            Controls.Add(gumbFighter);
            Controls.Add(gumbRanger);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChooseAClass";
            Text = "Choose a Class";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button gumbRanger;
        private Button gumbFighter;
        private Button gumbWizard;
    }
}
