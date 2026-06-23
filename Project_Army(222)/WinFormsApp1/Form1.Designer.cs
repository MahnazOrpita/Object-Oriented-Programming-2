namespace WinFormsApp1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            Star = new PictureBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            txticon1 = new PictureBox();
            txticon2 = new PictureBox();
            textname = new TextBox();
            textpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txticon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txticon2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TF_1;
            pictureBox1.Location = new Point(-248, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1372, 664);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Star
            // 
            Star.Image = Properties.Resources.star;
            Star.Location = new Point(274, 41);
            Star.Name = "Star";
            Star.Size = new Size(83, 81);
            Star.SizeMode = PictureBoxSizeMode.Zoom;
            Star.TabIndex = 1;
            Star.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(202, 350);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(210, 34);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Keep Me Login";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(184, 147);
            label1.Name = "label1";
            label1.Size = new Size(263, 29);
            label1.TabIndex = 8;
            label1.Text = "Journey Begins Here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // txticon1
            // 
            txticon1.Image = Properties.Resources.pngtree_black_classical_text_box_material_png_image_4247408;
            txticon1.Location = new Point(202, 215);
            txticon1.Name = "txticon1";
            txticon1.Size = new Size(222, 31);
            txticon1.SizeMode = PictureBoxSizeMode.CenterImage;
            txticon1.TabIndex = 9;
            txticon1.TabStop = false;
            // 
            // txticon2
            // 
            txticon2.Image = Properties.Resources.pngtree_black_classical_text_box_material_png_image_4247408;
            txticon2.Location = new Point(202, 288);
            txticon2.Name = "txticon2";
            txticon2.Size = new Size(222, 31);
            txticon2.SizeMode = PictureBoxSizeMode.CenterImage;
            txticon2.TabIndex = 10;
            txticon2.TabStop = false;
            // 
            // textname
            // 
            textname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textname.Location = new Point(202, 215);
            textname.Name = "textname";
            textname.Size = new Size(222, 31);
            textname.TabIndex = 11;
            textname.Text = "Type Your Name";
            textname.TextAlign = HorizontalAlignment.Center;
            textname.TextChanged += textname_TextChanged;
            // 
            // textpass
            // 
            textpass.BackColor = SystemColors.HighlightText;
            textpass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textpass.Location = new Point(202, 288);
            textpass.Name = "textpass";
            textpass.Size = new Size(222, 31);
            textpass.TabIndex = 12;
            textpass.Text = "Type Your Password";
            textpass.TextAlign = HorizontalAlignment.Center;
            textpass.TextChanged += textid_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(214, 410);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 13;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Stencil", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(649, 598);
            button2.Name = "button2";
            button2.Size = new Size(336, 29);
            button2.TabIndex = 14;
            button2.Text = "JOIN US NOW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 656);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textpass);
            Controls.Add(textname);
            Controls.Add(txticon2);
            Controls.Add(txticon1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(Star);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Star).EndInit();
            ((System.ComponentModel.ISupportInitialize)txticon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txticon2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Star;
        public TextBox textBox1;
        public TextBox textBox2;
        private CheckBox checkBox1;
        private Label label1;
        private PictureBox txticon1;
        private PictureBox txticon2;
        private TextBox textname;
        private TextBox textpass;
        private Button button1;
        private Button button2;
    }
}
