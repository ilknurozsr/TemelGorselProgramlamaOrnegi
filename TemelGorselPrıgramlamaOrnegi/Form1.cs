using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemelGorselPrıgramlamaOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); //textBox'a yazılan text'i listBox1'e at.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--) //listBox1'deki elemanları karşıya attığımız için eksilerek gidiyor ve listBox1'in uzunluğu kadar dönüyor.
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]); //listBox1'deki seçilen elemanları listBox2'ye at.
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]); //listBox1'i temizlemek için.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--) //listBox2'deki elemanları karşıya attığımız için eksilerek gidiyor ve listBox2'in uzunluğu kadar dönüyor.
            {
                {
                    listBox1.Items.Add(listBox2.SelectedItems[i]); //listBox2'deki seçilen elemanları listBox1'e at
                    listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]); //listBox2'yi temizlemek için
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple; //from açıldığında listBox'tan çoklu seçim yapmaya yarar.
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }
    }
}
