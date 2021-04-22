using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAcalc
{
    public partial class Form1 : Form
    {
        private float arg1;
        private int oper; // 0 - 3
        private int maxSymbol;
        public Form1()
        {
            InitializeComponent();
            arg1 = 0;
            oper = 0;
            maxSymbol = 0;
        }

        private int SetTextKey(string Key, int maxSymbol)
        {
            if (textBox1.TextLength < 2)
            {
                if (textBox1.TextLength > 0)
                {
                    if ((float)System.Convert.ToDouble(textBox1.Text) == 0)
                    {
                        if (Key == ",") textBox1.Text += Key;
                        else textBox1.Text = Key;
                        maxSymbol = textBox1.TextLength;
                    }
                    else if ((maxSymbol + Key.Length) < 17)
                    {
                        textBox1.Text += Key;
                        maxSymbol += Key.Length;
                    }
                }
                else if ((maxSymbol + Key.Length) < 17)
                {
                    textBox1.Text = Key;
                    maxSymbol = Key.Length;
                }
            }
            else if ((maxSymbol + Key.Length) < 17)
            {
                textBox1.Text += Key;
                maxSymbol += Key.Length;
            }
            return maxSymbol;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("0", maxSymbol);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("1", maxSymbol);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("2", maxSymbol);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("3", maxSymbol);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("4", maxSymbol);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("5", maxSymbol);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("6", maxSymbol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("7", maxSymbol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("8", maxSymbol);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maxSymbol = SetTextKey("9", maxSymbol);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            arg1 = 0;
            oper = 0;
            maxSymbol = 0;
            textBox1.Text = ""; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            arg1 = (float)System.Convert.ToDouble(textBox1.Text);
            oper = 0;
            maxSymbol = 0;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            arg1 = (float)System.Convert.ToDouble(textBox1.Text);
            oper = 1;
            maxSymbol = 0;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            arg1 = (float)System.Convert.ToDouble(textBox1.Text);
            oper = 2;
            maxSymbol = 0;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            arg1 = (float)System.Convert.ToDouble(textBox1.Text);
            oper = 3;
            maxSymbol = 0;
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            switch (oper)
            {
                case 0:
                    textBox1.Text = System.Convert.ToString(arg1 + 
                        (float)System.Convert.ToDouble(textBox1.Text));
                    break;
                case 1:
                    textBox1.Text = System.Convert.ToString(arg1 - 
                        (float)System.Convert.ToDouble(textBox1.Text));
                    break;
                case 2:
                    textBox1.Text = System.Convert.ToString(arg1 * 
                        (float)System.Convert.ToDouble(textBox1.Text));
                    break;
                case 3:
                    textBox1.Text = System.Convert.ToString(arg1 / 
                        (float)System.Convert.ToDouble(textBox1.Text));
                    break;
            }
            arg1 = 0;
            oper = 0;
            maxSymbol = textBox1.TextLength;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Название программы: Калькулятор\nПрограмма сделана на практическом занятии по ООП\nРазработчики программы:\n\tВязгин Олег\n\tОбъедков Илья\n\tФабричный Кирилл", "Информация");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0) Clipboard.SetText(textBox1.Text);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Clipboard.GetText()))
            {
                float chislo;
                if (float.TryParse(Clipboard.GetText(), out chislo))
                {
                    textBox1.Text = "";
                    maxSymbol = 0;
                    maxSymbol = SetTextKey(Clipboard.GetText(), maxSymbol);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "0,";
                maxSymbol = textBox1.TextLength;
            }
            else if (!textBox1.Text.Contains(",")) maxSymbol = SetTextKey(",", maxSymbol);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            textBox1.Text = System.Convert.ToString((float)System.Convert.ToDouble(textBox1.Text) * -1.0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1) return;
            string Text = textBox1.Text;
            textBox1.Text = Text.Remove(Text.Length-1, 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            maxSymbol = 0;
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
