using System;
using System.Windows.Forms;

namespace Lab5_Debugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
private void btnCalculateLinear_Click(object sender, EventArgs e)
{
    try
    {
        double x = double.Parse(txtX_Linear.Text.Replace(".", ","));
        double y = double.Parse(txtY_Linear.Text.Replace(".", ","));
        double z = double.Parse(txtZ_Linear.Text.Replace(".", ","));
        double tanSquared = Math.Pow(Math.Tan(x + y), 2);
        double expPart = Math.Exp(y - z);
        double sqrtPart = Math.Sqrt(Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(z), 2));
        
        double u = tanSquared - expPart * sqrtPart;
        txtResult_Linear.Text = u.ToString("F4");
        
        txtIntermediate.Text = $"tg²(x+y) = {tanSquared:F4}\ne^(y-z) = {expPart:F4}\n√(cos²x + sin²z) = {sqrtPart:F4}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Ошибка: введите корректные числа!", 
                      "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ошибка вычисления: {ex.Message}", 
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
        private double CalculateFunction(double x, string functionType)
        {
            switch (functionType)
            {
                case "sin(x)":
                    return Math.Sin(x);
                case "cos(x)":
                    return Math.Cos(x);
                case "e^x":
                    return Math.Exp(x);
                case "x²":
                    return Math.Pow(x, 2);
                default:
                    return Math.Sin(x);
            }
        }

        private void btnCalculateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX_Branch.Text.Replace(".", ","));
                double y = double.Parse(txtY_Branch.Text.Replace(".", ","));
                string functionType = cmbFunction.SelectedItem?.ToString() ?? "sin(x)";

                double fx = CalculateFunction(x, functionType);

                double result;
                string formulaUsed;

                if (x >= 1 && x < 5)
                {
                    result = Math.Pow(fx, 2) + Math.Atan(fx);
                    formulaUsed = "f²(x) + arctg(f(x))";
                }
                else if (y > x)
                {
                    result = Math.Pow(y - fx, 2) + Math.Atan(fx);
                    formulaUsed = "(y - f(x))² + arctg(f(x))";
                }
                else
                {
                    result = Math.Pow(y + fx, 3) + 0.5;
                    formulaUsed = "(y + f(x))³ + 0.5";
                }

                txtResult_Branch.Text = result.ToString("F4");
                txtFormulaUsed.Text = formulaUsed; 
                txtFxValue.Text = fx.ToString("F4");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите корректные числа!",
                              "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLinear_Click(object sender, EventArgs e)
        {
            txtX_Linear.Clear();
            txtY_Linear.Clear();
            txtResult_Linear.Clear();
            txtX_Linear.Focus();
        }

        private void btnClearBranch_Click(object sender, EventArgs e)
        {
            txtX_Branch.Clear();
            txtY_Branch.Clear();
            txtResult_Branch.Clear();
            txtFormulaUsed.Clear();
            txtFxValue.Clear();
            cmbFunction.SelectedIndex = 0;
            txtX_Branch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}