using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_Proje_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox_Ad.Text + "  " + textBox_Soyad.Text + "  "+maskedTextBox_TC.Text+"  "+maskedTextBox_Telefon.Text+"  "+dateTimePicker_Dogum.Text+"   "+comboBox_Sehir.Text);
        }
    }
}
