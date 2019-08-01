using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            emlk eml = new emlk();
            eml.semti = textBox1.Text;
            eml.RENGİ = textBox2.Text;
            eml.odasayisi =Convert.ToInt32(textBox3.Text);
            eml.katnosu = Convert.ToInt32(textBox4.Text);
            eml.alanı = Convert.ToDouble(textBox5.Text);

            dataGridView1.Rows.Add(eml.semti, eml.RENGİ, eml.odasayisi, eml.katnosu, eml.alanı);
            progressBar1.Value = 100;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox3.Text == null)
            {
                button1.Visible = false;
            }
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "SEMTİ";
            dataGridView1.Columns[1].Name = "RENGİ";
            dataGridView1.Columns[2].Name = "ODA SAYISI";
            dataGridView1.Columns[3].Name = "KAT NUMARASI";
            dataGridView1.Columns[4].Name = "TOPLAM ALANI";        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            progressBar1.Value = 0;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if
            (dataGridView1.SelectedRows.Count > 0)
            {
             dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
           MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if
        (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.SelectedCells[0].Value = null;
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek hücreyi Seçin!");
            }

        }

       
    }
}
