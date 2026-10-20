using Microsoft.Win32;

namespace delegatesAndEvents
{
    public partial class frmCalculator : Form
    {
        Formula <double, string> Formula;
        private double num1, num2;
        public frmCalculator()
        {
            InitializeComponent();
            char[] operations = { '+', '-', '*', '/' };

            foreach (char c in operations)
            {
                comboBox1.Items.Add(c.ToString());
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtBoxInput1.Text);
            num2 = double.Parse(txtBoxInput2.Text);
            string operation = comboBox1.SelectedItem.ToString();

            switch (operation)
            {
                case "+":
                    Formula = new Formula<double,string>(CalculatorClass.getSum);
                    lblDisplayTotal.Text = Convert.ToString(CalculatorClass.getSum(num1, num2, operation));
                    break;

                case "-":
                    Formula = new Formula<double, string>(CalculatorClass.getDifference);
                    lblDisplayTotal.Text = Convert.ToString(CalculatorClass.getDifference(num1, num2, operation));
                    break;

                case "*":
                    Formula = new Formula<double, string>(CalculatorClass.getProduct);
                    lblDisplayTotal.Text = Convert.ToString(CalculatorClass.getProduct(num1, num2, operation));
                    break;

                case "/":
                    Formula = new Formula<double, string>(CalculatorClass.getQuotient);
                    try
                    {
                        lblDisplayTotal.Text = Convert.ToString(CalculatorClass.getQuotient(num1, num2, operation));
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
         }
    }
}
