using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class WillemKlein : Form
    {
        public WillemKlein()
        {
            InitializeComponent();
        }

        private async void plusButton_Click(object sender, EventArgs e)
        {
            await HandleButtonEvent((Button)sender, plusResult, () => inputA.Value + inputB.Value);
        }

        private async void minusButton_Click(object sender, EventArgs e)
        {
            await HandleButtonEvent((Button)sender, minusResult, () => inputA.Value - inputB.Value);
        }

        private async void multiplyButton_Click(object sender, EventArgs e)
        {
            await HandleButtonEvent((Button)sender, multiplyResult, () => inputA.Value * inputB.Value);
        }

        private async void divideButton_Click(object sender, EventArgs e)
        {
            await HandleButtonEvent((Button)sender, divideResult, () => inputA.Value / inputB.Value);
        }

        private async void powerButton_Click(object sender, EventArgs e)
        {
            await HandleButtonEvent((Button)sender, powerResult, () => (decimal)Math.Pow((double)inputA.Value, (double)inputB.Value));
        }

        private async Task HandleButtonEvent(Button button, Label label, Func<decimal> getResult)
        {
            var rememberText = button.Text;

            button.Enabled = false;
            button.Text = "∞";

            await Task.Delay(1250);

            button.Enabled = true;
            button.Text = rememberText;

            label.Text = getResult().ToString();
        }
    }
}
