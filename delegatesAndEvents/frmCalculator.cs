using Microsoft.Win32;

namespace delegatesAndEvents
{
    public partial class frmCalculator : Form
    {
        public CalculatorClass cal;
        private double num1, num2;
        private string operation = string.Empty;

        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtBoxInput1.Text);
            num2 = double.Parse(txtBoxInput2.Text);

            if (comboBox1.SelectedItem is null)
            {
                MessageBox.Show("Please select an operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            operation = comboBox1.SelectedItem.ToString() ?? string.Empty;
            switch (operation)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.getSum);
                    lblDisplayTotal.Text = Convert.ToString(cal.getSum(num1, num2));
                    cal.CalculateEvent -= new Formula<double>(cal.getSum);
                    break;

                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.getDifference);
                    lblDisplayTotal.Text = Convert.ToString(cal.getDifference(num1, num2));
                    cal.CalculateEvent -= new Formula<double>(cal.getDifference);
                    break;

                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.getProduct);
                    lblDisplayTotal.Text = Convert.ToString(cal.getProduct(num1, num2));
                    cal.CalculateEvent -= new Formula<double>(cal.getProduct);
                    break;

                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.getQuotient);
                    try
                    {
                        lblDisplayTotal.Text = Convert.ToString(cal.getQuotient(num1, num2));
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cal.CalculateEvent -= new Formula<double>(cal.getQuotient);
                    break;
            }
        }
    }
}
