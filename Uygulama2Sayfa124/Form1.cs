using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2Sayfa124
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[3]; 
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLİstele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            index++;
        }
    }
}
