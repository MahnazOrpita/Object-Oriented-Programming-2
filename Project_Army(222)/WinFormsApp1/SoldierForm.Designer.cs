namespace WinFormsApp1
{
    partial class SoldierForm
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
            missioninfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.soldier_holding_radio_logo_design_illustration_vector;
            pictureBox1.Location = new Point(-284, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1343, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // missioninfo
            // 
            missioninfo.BackColor = SystemColors.ButtonHighlight;
            missioninfo.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missioninfo.Location = new Point(547, 32);
            missioninfo.Name = "missioninfo";
            missioninfo.Size = new Size(211, 102);
            missioninfo.TabIndex = 1;
            missioninfo.Text = "MISSION INFO";
            missioninfo.UseVisualStyleBackColor = false;
            missioninfo.Click += button1_Click;
            // 
            // SoldierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(missioninfo);
            Controls.Add(pictureBox1);
            Name = "SoldierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoldierForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button missioninfo;
    }
}