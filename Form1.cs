using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float num, savenum;
        int count;
        bool znak = true;
        int systema=10;
        int ressystema = 10;

        private void AddNum(string a)
        {
            textBox1.Text = textBox1.Text + a;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            AddNum("0");
        }


        private void button7_Click(object sender, EventArgs e)
        {
            AddNum("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNum("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNum("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNum("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNum("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNum("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNum("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNum("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNum("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddNum(",");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text, systema);
            textBox1.Clear();
            count = 1;
            label1.Text = num.ToString() + "+";
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text, systema);
            textBox1.Clear();
            count = 2;
            label1.Text = num.ToString() + "-";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text, systema);
            textBox1.Clear();
            count = 3;
            label1.Text = num.ToString() + "*";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text, systema);
            textBox1.Clear();
            count = 4;
            label1.Text = num.ToString() + "/";
            znak = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            AddNum("A");
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            AddNum("B");
        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            AddNum("C");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            systema = 2;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            systema = 8;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            systema = 16;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ressystema = 2;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ressystema = 8;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ressystema = 16;
        }

        private void Calculate()
        {
            
            switch (count)
            {
                case 1:
                    
                    savenum = num + Convert.ToInt32(textBox1.Text, systema);//любая система в 10
                    textBox1.Text = Convert.ToInt32(Convert.ToString(Convert.ToInt32(savenum), ressystema)).ToString();//из 10 в любую систему
                    break;
                case 2:
                    savenum = num - Convert.ToInt32(textBox1.Text, systema);
                    textBox1.Text = Convert.ToInt32(Convert.ToString(Convert.ToInt32(savenum), ressystema)).ToString();
                    break;
                case 3:
                    savenum = num * Convert.ToInt32(textBox1.Text, systema);
                    textBox1.Text = Convert.ToInt32(Convert.ToString(Convert.ToInt32(savenum), ressystema)).ToString();
                    break;
                case 4:
                    savenum = num / Convert.ToInt32(textBox1.Text, systema);
                    textBox1.Text = Convert.ToInt32(Convert.ToString(Convert.ToInt32(savenum), ressystema)).ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
