using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //([0-9][a-zA-Z])* -> ([0-9][a-zA-Z])*
       
        public static string reg = @"([0-9][a-zA-Z]) \+? ([0-9][a-zA-Z])* -> ([0-9][a-zA-Z])*";
        public static Regex regex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input.TextChanged += metroTextBox1_TextChanged;
          regex = new Regex(reg);
        }
        private void metroTextBox1_TextChanged(object sender,EventArgs e)
        {
            string t = input.Text;
            if (regex.Match(t).Success)
            {
                
                metroPanel1.Show();
            }
        }
        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
