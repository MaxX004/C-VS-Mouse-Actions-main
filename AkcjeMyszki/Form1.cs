using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AkcjeMyszki
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form_MouseWheel;
            this.MouseDown += Form1_MouseDown;           
            textBox1.Text = Convert.ToString(Licznik);
             
    }

        string Podmiana;


        int Licznik = 0;
        public virtual System.Drawing.Font Font { get; set; }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 50);
                textBox1.Text = "Lewy";
                textBox1.SelectAll();
                textBox1.Focus();
            }
            else if (e.Button == MouseButtons.Right)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 50);
                textBox1.Text = "Prawy";
                textBox1.SelectAll();
                textBox1.Focus();
            }
            else if(e.Button == MouseButtons.Middle)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 50);
                textBox1.Text = "Środkowy";
                textBox1.SelectAll();
                textBox1.Focus();
            }    
            else if(e.Button == MouseButtons.XButton1)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 28);
                textBox1.Text = "Pierwszy przycisk boczny";
                textBox1.SelectAll();
                textBox1.Focus();
            }
            else if (e.Button == MouseButtons.XButton2)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 28);
                textBox1.Text = "Drugi przycisk boczny";
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }
        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                try
                {
                    Podmiana = textBox1.Text;
                    Licznik = Convert.ToInt32(Podmiana);
                    Licznik++;
                    textBox1.Text = Convert.ToString(Licznik);
                }
                catch(System.FormatException)
                {
                    textBox1.Font = new Font("Microsoft Sans Serif", 50);
                    textBox1.Text = "Wpisz cyfrę!";
                    textBox1.SelectAll();
                    textBox1.Focus();
                }
            }
            else
            {
                try
                {
                    Podmiana = textBox1.Text;
                    Licznik = Convert.ToInt32(Podmiana);
                    Licznik--;
                    textBox1.Text = Convert.ToString(Licznik);
                }
                catch (System.FormatException)
                {
                    textBox1.Text = "Wpisz cyfrę!";
                    textBox1.SelectAll();
                    textBox1.Focus();
                }


            }
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        public void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
