namespace C_Homework4
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
            maxButton = new Button();
            powerButton = new Button();
            isPrimeButton = new Button();
            factorialButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // maxButton
            // 
            maxButton.Location = new Point(247, 137);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(94, 29);
            maxButton.TabIndex = 0;
            maxButton.Text = "Button";
            maxButton.UseVisualStyleBackColor = true;
            maxButton.Click += maxButton_Click;
            // 
            // powerButton
            // 
            powerButton.Location = new Point(247, 182);
            powerButton.Name = "powerButton";
            powerButton.Size = new Size(94, 33);
            powerButton.TabIndex = 1;
            powerButton.Text = "Power";
            powerButton.UseVisualStyleBackColor = true;
            powerButton.Click += powerButton_Click;
            // 
            // isPrimeButton
            // 
            isPrimeButton.Location = new Point(402, 137);
            isPrimeButton.Name = "isPrimeButton";
            isPrimeButton.Size = new Size(85, 29);
            isPrimeButton.TabIndex = 3;
            isPrimeButton.Text = "IsPrime";
            isPrimeButton.UseVisualStyleBackColor = true;
            isPrimeButton.Click += isPrimeButton_Click;
            // 
            // factorialButton
            // 
            factorialButton.Location = new Point(402, 185);
            factorialButton.Name = "factorialButton";
            factorialButton.Size = new Size(85, 30);
            factorialButton.TabIndex = 5;
            factorialButton.Text = "Factorial";
            factorialButton.UseVisualStyleBackColor = true;
            factorialButton.Click += factorialButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 8;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(344, 246);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(56, 20);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Result :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(factorialButton);
            Controls.Add(isPrimeButton);
            Controls.Add(powerButton);
            Controls.Add(maxButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button maxButton;
        private Button powerButton;
        private Button isPrimeButton;
        private Button factorialButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label resultLabel;
    }
}
