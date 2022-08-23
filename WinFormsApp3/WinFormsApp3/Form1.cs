using System.Linq;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int[] tmp = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            label2.Text = "Array: ";
            label3.Text = "Total: ";
            label4.Text = "Sort by Dec: ";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int[] arr = new int[n + 1];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            if (n < 0)
            {
                MessageBox.Show("Enter n > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string arrToString = "";
            for (int i = 0; i < n; i++)
            {
                arrToString += arr[i] + " ";
            }
            label2.Text = "Array: " + arrToString;
            tmp = arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int v in tmp)
            {
                sum += v;
            }
            label3.Text = "Total: " + sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(tmp);
            string arrToString = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                arrToString += tmp[i] + " ";
            }
            label4.Text = "Array: " + arrToString;
        }
    }
}