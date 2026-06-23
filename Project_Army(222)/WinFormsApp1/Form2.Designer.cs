namespace WinFormsApp1
{
    partial class AdminForm
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
            pictureBox1 = new PictureBox();
            mission = new Button();
            equipment = new Button();
            Soldier = new Button();
            Unit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GENERAL_PORTAL;
            pictureBox1.Location = new Point(-377, -187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1802, 846);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // mission
            // 
            mission.BackColor = SystemColors.ButtonHighlight;
            mission.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mission.Location = new Point(38, 67);
            mission.Name = "mission";
            mission.Size = new Size(200, 66);
            mission.TabIndex = 1;
            mission.Text = "Assign Mission";
            mission.UseVisualStyleBackColor = false;
            // 
            // equipment
            // 
            equipment.BackColor = SystemColors.ButtonHighlight;
            equipment.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equipment.Location = new Point(38, 376);
            equipment.Name = "equipment";
            equipment.Size = new Size(200, 66);
            equipment.TabIndex = 2;
            equipment.Text = "Equipment";
            equipment.UseVisualStyleBackColor = false;
            // 
            // Soldier
            // 
            Soldier.BackColor = SystemColors.ButtonHighlight;
            Soldier.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Soldier.Location = new Point(796, 67);
            Soldier.Name = "Soldier";
            Soldier.Size = new Size(200, 66);
            Soldier.TabIndex = 3;
            Soldier.Text = "Soldier Details";
            Soldier.UseVisualStyleBackColor = false;
            Soldier.Click += Soldier_Click;
            // 
            // Unit
            // 
            Unit.BackColor = SystemColors.ButtonHighlight;
            Unit.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Unit.Location = new Point(796, 393);
            Unit.Name = "Unit";
            Unit.Size = new Size(200, 66);
            Unit.TabIndex = 4;
            Unit.Text = "Unit Details";
            Unit.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(Unit);
            Controls.Add(Soldier);
            Controls.Add(equipment);
            Controls.Add(mission);
            Controls.Add(pictureBox1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button mission;
        private Button equipment;
        private Button Soldier;
        private Button Unit;
    }
}