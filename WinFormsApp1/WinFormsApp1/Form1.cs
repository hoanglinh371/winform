namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aInput_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(aInput, "Enter a integer number");
        }

        private void bInput_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(bInput, "Enter a integer number");
        }

        private void againBtn_Click(object sender, EventArgs e)
        {
            aInput.Text = "";
            bInput.Text = "";
            resultLbl.Text = "Total from a to b is: ";
            aInput.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you want to exit?",
                "Waring",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)

                this.Close();
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bInput.Text) || string.IsNullOrWhiteSpace(aInput.Text))
            {
                MessageBox.Show("Fields must be fill", "Error");
            }
            else
            {
                int a = int.Parse(aInput.Text);
                int b = int.Parse(bInput.Text);
                int sum = 0;

                if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                }
                else if (a > b)
                {
                    for (int i = b; i <= a; i++)
                    {
                        sum += i;
                    }
                }
                else
                {
                    sum = a;
                }

                resultLbl.Text = "Total from " + aInput.Text + " to " + bInput.Text + " is: " + sum.ToString();
            }
        }

        private void aInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}