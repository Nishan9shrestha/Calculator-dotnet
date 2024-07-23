using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool operationPerformed = false;
        private bool resultDisplayed = false; // Tracks if the result is currently displayed

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        // for every digit clicked from 0-9
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxDisplay.Text == "0") || (operationPerformed) || resultDisplayed)
                textBoxDisplay.Clear();

            operationPerformed = false;
            resultDisplayed = false; // Reset resultDisplayed when a new input is given
            Button button = (Button)sender;
            textBoxDisplay.Text += button.Text;
        }
        //For Every operator clicked
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Append the operator to the display
            textBoxDisplay.Text += button.Text;
        }
        //for dot
        private void dot(object sender, EventArgs e)
        {
            operationPerformed = false;
            Button button = (Button)sender;
            // Append the decimal point to the display
            textBoxDisplay.Text += button.Text;
        }
        //to perform every operations after equal is clicked
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBoxDisplay.Text, null);
                textBoxDisplay.Text = result.ToString();
                resultDisplayed = true; // Mark that the result is now displayed
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Expression");
                textBoxDisplay.Text = "0";
                resultDisplayed = false;
            }
        }
        //fro All Clear button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            resultDisplayed = false; // Reset resultDisplayed
        }
        //for clear button
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                textBoxDisplay.Text = "0"; // Clear the result if displayed
                resultDisplayed = false;
            }
            else if (textBoxDisplay.Text.Length > 0)
            {
                // Remove the last character
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1);
                // If the display becomes empty, set it to "0"
                if (textBoxDisplay.Text == "")
                    textBoxDisplay.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonBackspace_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonClear_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dot(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonEquals_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        
    }
}
