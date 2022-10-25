namespace KryptoSolver
{
    public partial class KryptoSolver : Form
    {
        public KryptoSolver()
        {
            InitializeComponent();
        }
        public string[] results = new string[2];
        public bool calced = false;
        private void input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled=!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') { }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (input1.Text != "" && input2.Text != "" && input3.Text != "" && input4.Text != "" && input5.Text != "" && input6.Text != "")
            {
                float num1 = Convert.ToInt32(input1.Text);
                float num2 = Convert.ToInt32(input2.Text);
                float num3 = Convert.ToInt32(input3.Text);
                float num4 = Convert.ToInt32(input4.Text);
                float num5 = Convert.ToInt32(input5.Text);
                float num6 = Convert.ToInt32(input6.Text);
                results = Logic.Solver(new float[] {num1,num2,num3,num4,num5,num6});
                SolutionsCount.Text = "Count: " + Convert.ToString(results.Length);
                SelecterBar.Maximum = results.Length;
                Selected.Text = "Selected: 1";
                if (results[0] != "No Solutions Found")
                {
                    calced = true;
                    SelecterBar.Value = 1;
                    output.Text = results[0];
                }
                else
                {
                    output.Text = "No Possible Solution";
                }


            }
        }

        private void SelecterBar_Scroll(object sender, EventArgs e)
        {
            Selected.Text = "Selected: " + SelecterBar.Value;
            output.Text = results[SelecterBar.Value - 1];
        }
    }
}