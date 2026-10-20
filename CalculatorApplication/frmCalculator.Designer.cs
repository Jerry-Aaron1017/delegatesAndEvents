namespace calculatorApplication
{
    partial class frmCalculator
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
            txtBoxInput1 = new TextBox();
            firstNumber = new Label();
            secondNumber = new Label();
            txtBoxInput2 = new TextBox();
            comboBox1 = new ComboBox();
            answerLabel = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(207, 12);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(159, 29);
            txtBoxInput1.TabIndex = 0;
            // 
            // firstNumber
            // 
            firstNumber.AutoSize = true;
            firstNumber.Font = new Font("Segoe UI", 12F);
            firstNumber.Location = new Point(52, 15);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(149, 21);
            firstNumber.TabIndex = 1;
            firstNumber.Text = "Enter First Number: ";
            // 
            // secondNumber
            // 
            secondNumber.AutoSize = true;
            secondNumber.Font = new Font("Segoe UI", 12F);
            secondNumber.Location = new Point(31, 58);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(170, 21);
            secondNumber.TabIndex = 3;
            secondNumber.Text = "Enter Second Number: ";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(207, 55);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(159, 29);
            txtBoxInput2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 29);
            comboBox1.TabIndex = 4;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font("Segoe UI", 12F);
            answerLabel.Location = new Point(95, 124);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(69, 21);
            answerLabel.TabIndex = 5;
            answerLabel.Text = "Answer: ";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(170, 124);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 21);
            lblDisplayTotal.TabIndex = 6;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Crimson;
            btnEqual.Font = new Font("Segoe UI", 14F);
            btnEqual.ForeColor = SystemColors.Control;
            btnEqual.Location = new Point(139, 167);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(133, 38);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 245);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(answerLabel);
            Controls.Add(comboBox1);
            Controls.Add(secondNumber);
            Controls.Add(txtBoxInput2);
            Controls.Add(firstNumber);
            Controls.Add(txtBoxInput1);
            Name = "Form1";
            Text = "Calculator";
            CenterToScreen();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox txtBoxInput1;
        private Label firstNumber;
        private Label secondNumber;
        private TextBox txtBoxInput2;
        private ComboBox comboBox1;
        private Label answerLabel;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
