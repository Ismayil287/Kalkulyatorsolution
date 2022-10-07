using System;

namespace Kalkulyator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float result, firstdigit1;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" )
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else textBox1.Text += button.Text;
        }

        private void buttonbackspacee_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "0";
            }
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            {
                result = float.Parse(textBox1.Text);
                result = result * -1;
                textBox1.Text = result.ToString();
            }
        }

        private void buttonpercentage_Click(object sender, EventArgs e)
        {
            result = float.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) 
            {
                compute(count);
            }
                
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    textBox1.Text = (firstdigit1 + float.Parse(textBox1.Text)).ToString();
                    break;
                case 2:
                    textBox1.Text = (firstdigit1 - float.Parse(textBox1.Text)).ToString();
                    break;
                case 3:
                    textBox1.Text = (firstdigit1 / float.Parse(textBox1.Text)).ToString();
                    break;
                case 4:
                    textBox1.Text = (firstdigit1 * float.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                firstdigit1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                firstdigit1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
            firstdigit1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            }
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                firstdigit1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
            }
        }
    }
}