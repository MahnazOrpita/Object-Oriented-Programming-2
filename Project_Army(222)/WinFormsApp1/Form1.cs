namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textname.Text;
            string password = textpass.Text;

            if (username == "Imtiaz" && password == "22468141")
            {
                AdminForm A2 = new AdminForm();
                //A2.WindowState = FormWindowState.Maximized;
                A2.Show();
                this.Hide();
                MessageBox.Show("Welcome Admin");
            }
            else if (username == "Faishal" && password == "1234")
            {
                OfficerForm O2 = new OfficerForm();
               // O2.WindowState = FormWindowState.Maximized;
                O2.Show();
                this.Hide();
                MessageBox.Show("Welcome Officer");
            }
            else if ((username == "Orpita" && password == "3456") || (username == "Jerin" && password == "4567"))
            {
                SoldierForm S2 = new SoldierForm();
               // S2.WindowState = FormWindowState.Maximized;
                S2.Show();
                this.Hide();
                MessageBox.Show("Welcome Soldier");
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password must be inserted");
            }
            else
            {
                MessageBox.Show("Enter valid details");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
