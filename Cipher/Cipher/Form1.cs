using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string al = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя 0123456789";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ori(textBox1.Text);
        }
       
        public string ori(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox3.Text;
            string sd = textBox1.Text;
            int step = Convert.ToInt32(sd);   
            for (int i=0;  i < s.Length; i++)
            for (int j = 0; j < al.Length; j++)
            if (s[i]==al[j]) code.Append(al[(j+step)% al.Length]);
            return code.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = org(textBox1.Text);
        }

        public string org(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox2.Text;
            string sd = textBox1.Text;
            int step = Convert.ToInt32(sd);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < al.Length; j++)
                    if (s[i] == al[j]) code.Append(al[(j - step + al.Length) % al.Length]);
            return code.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
