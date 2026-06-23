namespace WinFormsApp1
{
    partial class OfficerForm
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
            Button equipment;
            Officer = new PictureBox();
            equipment = new Button();
            ((System.ComponentModel.ISupportInitialize)Officer).BeginInit();
            SuspendLayout();
            // 
            // Officer
            // 
            Officer.Image = Properties.Resources._2ffae15915a8b9d98edc72497fbdd5e2;
            Officer.Location = new Point(-391, -98);
            Officer.Name = "Officer";
            Officer.Size = new Size(1385, 771);
            Officer.SizeMode = PictureBoxSizeMode.Zoom;
            Officer.TabIndex = 0;
            Officer.TabStop = false;
            // 
            // equipment
            // 
            equipment.BackColor = SystemColors.InfoText;
            equipment.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equipment.ForeColor = Color.Red;
            equipment.Location = new Point(511, 415);
            equipment.Name = "equipment";
            equipment.Size = new Size(143, 81);
            equipment.TabIndex = 1;
            equipment.Text = "Equipment";
            equipment.UseVisualStyleBackColor = false;
            // 
            // OfficerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 520);
            Controls.Add(equipment);
            Controls.Add(Officer);
            Name = "OfficerForm";
            Text = "OfficerForm";
            ((System.ComponentModel.ISupportInitialize)Officer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Officer;
    }
}