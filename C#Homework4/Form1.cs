namespace C_Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Max(double a, double b)
        {
            return Math.Max(a, b);
        }

        private double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private long Factorial(int n)
        {
            long result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        private void maxButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
    double.TryParse(textBox2.Text, out double b))
            {
                resultLabel.Text = $"Result: {Max(a, b)}";
            }
            else
            {
                MessageBox.Show(
                    "Please enter valid numbers.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {


            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
            {
                double result = Power(a, b);

                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    MessageBox.Show(
                        "The result is not a valid number.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                resultLabel.Text = $"Result: {result}";
            }
            else
            {
                MessageBox.Show(
                    "Please enter valid numbers.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void isPrimeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                if (n < 2)
                {
                    MessageBox.Show(
                        "Enter an integer greater than or equal to 2.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                resultLabel.Text = IsPrime(n)
                    ? $"{n} is a prime number."
                    : $"{n} is not a prime number.";
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid integer in the first box.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
           if(int.TryParse(textBox1.Text, out int n) &&
          n >= 0 && n <= 20)
           {
                resultLabel.Text = $"{n}! = {Factorial(n)}";
            }
            else
            {
                MessageBox.Show(
                    "Enter a whole number between 0 and 20.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
