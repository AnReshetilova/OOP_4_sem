﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        const string NO_INFO = "00000000000000000000";
        public Form1()
        {
            InitializeComponent();
        }

        private void ONE_button_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength >= textBox.MaxLength)
            {
                textBox.Text = textBox.Text.Remove(0,1);
            }
            textBox.Text += '1';
        }

        private void NULL_button_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength >= textBox.MaxLength)
            {
                textBox.Text = textBox.Text.Remove(0, 1);
            }
            textBox.Text += '0';
        }

        private void AND_button_Click(object sender, EventArgs e)
        {
            Calculator.FirstArg = textBox.Text;
            Calculator.Operation = Operations.and;
            textBox.Text = NO_INFO;
        }

        private void GO_button_Click(object sender, EventArgs e)
        {
            Calculator.SecondArg = textBox.Text;
            textBox.Text = Calculator.GetResult();

            if (!binary_radioButton.Checked)
            {
                blockAll();
            }
        }

        private void OR_button_Click(object sender, EventArgs e)
        {
            Calculator.FirstArg = textBox.Text;
            Calculator.Operation = Operations.or;
            textBox.Text = NO_INFO;
        }

        private void NOT_button_Click(object sender, EventArgs e)
        {
            Calculator.FirstArg = textBox.Text;
            Calculator.Operation = Operations.not;
            textBox.Text = Calculator.GetResult();

            if (!binary_radioButton.Checked)
            {
                blockAll();
            }
        }

        private void RESET_button_Click(object sender, EventArgs e)
        {
            Calculator.FirstArg = "";
            Calculator.SecondArg = "";
            textBox.Text = NO_INFO;
            ONE_button.Enabled = true;
            NULL_button.Enabled = true;
            AND_button.Enabled = true;
            NOT_button.Enabled = true;
            OR_button.Enabled = true;
            GO_button.Enabled = true;
        }

        private void binary_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binary_radioButton.Checked == true)
            {
                Calculator.Style = Styles.binary;
            }
        }

        private void octal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (octal_radioButton.Checked == true)
            {
                Calculator.Style = Styles.octal;
            }
        }

        private void decimal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal_radioButton.Checked == true)
            {
                Calculator.Style = Styles.dec;
            }
        }

        private void hexadecimal_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hexadecimal_radioButton.Checked == true)
            {
                Calculator.Style = Styles.hexadec;
            }
        }

        private void blockAll()
        {
            ONE_button.Enabled = false;
            NULL_button.Enabled = false;
            AND_button.Enabled = false;
            NOT_button.Enabled = false;
            OR_button.Enabled = false;
            GO_button.Enabled = false;
        }
    }
}
