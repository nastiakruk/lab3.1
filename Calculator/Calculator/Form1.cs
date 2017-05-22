using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int Memory;
        private Stopwatch _timer = new Stopwatch();
        private string _checkExp;
        public Form1(String[] args)
        {
            InitializeComponent();
            Memory = 0;
            tbExpression.Text = args.Length != 0 ? string.Join(" ", args) : "0";
            _checkExp = tbExpression.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "1";
            else
                tbExpression.Text = "1";
        }
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbRes.Text == "")
                {
                    Memory = int.Parse(tbExpression.Text);
                    tbExpression.Text = "0";
                }
                else Memory = int.Parse(tbRes.Text);
            }
            catch
            {
                tbRes.Text = "Неможливо перетворити до числа";
            }
        }

        private void buttonP_m_Click(object sender, EventArgs e)
        {
            //if (_checkExp == tbExpression.Text) 
            //{ 
            if (!_timer.IsRunning)
            {
                _timer = Stopwatch.StartNew();

            }
            else
            {
                _timer.Stop();
                if (_timer.Elapsed.Seconds > 3)
                {
                    _timer.Reset();
                    _timer = Stopwatch.StartNew();
                    return;
                }
            }
            //}
            //else
            //{
            //    _timer.Reset();
            //}

            if (tbExpression.Text[tbExpression.Text.Length - 1] == 'm')
            {
                tbExpression.Text = tbExpression.Text.Remove(tbExpression.Text.Length - 1, 1);
                tbExpression.Text += 'p';
            }
            else
            {
                if (tbExpression.Text[tbExpression.Text.Length - 1] == 'p')
                {
                    tbExpression.Text = tbExpression.Text.Remove(tbExpression.Text.Length - 1, 1);
                    tbExpression.Text += 'm';
                }
                else
                {
                    if (tbExpression.Text == "0")
                    {
                        tbExpression.Text = "m";
                    }
                    else
                    {
                        tbExpression.Text += "m";
                    }
                }
            }

            _checkExp = tbExpression.Text;
        }
        private void buttonMClean_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }
        private void buttonMRead_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text == "0") tbExpression.Text = Memory.ToString();
            else if (Memory != 0) tbExpression.Text += Memory.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "2";
            else
                tbExpression.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "3";
            else
                tbExpression.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "4";
            else
                tbExpression.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "5";
            else
                tbExpression.Text = "5";
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    if (tbExpression.Text != "0")
        //        tbExpression.Text += "6";
        //    else
        //        tbExpression.Text = "6";
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "7";
            else
                tbExpression.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "8";
            else
                tbExpression.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "9";
            else
                tbExpression.Text = "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "0";
        }

        private void btShacle(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "(";
            else
                tbExpression.Text = "(";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += ")";
            else
                tbExpression.Text = ")";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            tbExpression.Text = "0";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            tbExpression.Text = tbExpression.Text.Remove(tbExpression.Text.Length - 1, 1);
            if (tbExpression.Text.Length == 0)
                tbExpression.Text = "0";
        }

        private void btDev(object sender, EventArgs e)
        {
            tbExpression.Text += "/";
        }

        private void btSub(object sender, EventArgs e)
        {
            tbExpression.Text += "-";
        }

        private void btSum(object sender, EventArgs e)
        {
            tbExpression.Text += "+";
        }

        private void clickMod(object sender, EventArgs e)
        {
            tbExpression.Text += "mod";
        }

        private void clMult(object sender, EventArgs e)
        {
            tbExpression.Text += "*";
        }

        private void bcResult(object sender, EventArgs e)
        {
            AnalaizerClass.Class2 alalizerOb = new AnalaizerClass.Class2(tbExpression.Text);
            tbRes.Text = AnalaizerClass.Class2.Estimate();
            tbExpression.Text = "0";
        }

        private void tbExpression_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyValue.ToString() == "13")
              bcResult(sender, e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Application.Exit(); }          

        }

        private void bt6_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbExpression.Text != "0")
                tbExpression.Text += "6";
            else
                tbExpression.Text = "6";
        }

        
    }
}
