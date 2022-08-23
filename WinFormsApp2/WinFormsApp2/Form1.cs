namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[12];
            int m = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Fields must be fill", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (m < 1 || m > 12)
            {
                MessageBox.Show("Month must be in range 1-12", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (textBox2.Text.Length != 4)
            {
                MessageBox.Show("Year must be have 4 characters", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (y % 4 == 0 || (y % 100 == 0 && y % 400 == 0))
            {
                int[] value = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                a = value;
            }
            else
            {
                int[] value = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                a = value;
            }

            label3.Text = m + " / " + y + " have " + a[m - 1] + " days";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "Result";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}