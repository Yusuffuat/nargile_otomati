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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oran_yaz()
        {
            label2.Text=(progressBar1.Value.ToString()+"/25gr");
        }

        string aroma_secim;
        int gr_secim = 0;
        int servis_edilen_lüle = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nargile Otomatı v1.0";
            progressBar1.Maximum = 25;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled=true;
            if (radioButton1.Checked)
            {
               aroma_secim=radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                aroma_secim = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                aroma_secim = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                aroma_secim = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                aroma_secim = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                aroma_secim = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                aroma_secim = radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                aroma_secim = radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                aroma_secim = radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                aroma_secim = radioButton10.Text;
            }

            if (radioButton11.Checked)
            {
                gr_secim = 5;
            }
            else if (radioButton12.Checked)
            {
                gr_secim = 10;
            }
            else if (radioButton13.Checked)
            {
                gr_secim = 15;
            }
            else if (radioButton14.Checked)
            {
                gr_secim = 20;
            }
            else if (radioButton15.Checked)
            {
                gr_secim = 25;
            }


            if (gr_secim + progressBar1.Value > 25)
            {
                MessageBox.Show("Maks Gramaj Aşıldı!");
            }
            else 
            {
                progressBar1.Value = progressBar1.Value + gr_secim;
                listBox1.Items.Add(aroma_secim + " - " + gr_secim+"gr.");
                oran_yaz();

                if (progressBar1.Value == 25)
                {
                    button3.Enabled=true;
                    button1.Enabled=false;
                }
                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilenItem = listBox1.SelectedItem as string;
            button1.Enabled = true;
            button3.Enabled = false;

            if (secilenItem != null)
            {
                string[] parts = secilenItem.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    if (int.TryParse(parts[1].Replace("gr.", ""), out int gr))
                    {
                        progressBar1.Value -= gr;

                        if (progressBar1.Value < 0)
                        {
                            progressBar1.Value = 0;
                        }

                        listBox1.Items.Remove(secilenItem);
                    }
                    oran_yaz();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lüle Dolduruldu! Hazneden Alınız!");
            button2.Enabled = false;
            listBox1.Items.Clear();
            button1.Enabled = true;
            progressBar1.Value = 0;
            oran_yaz();
            button3.Enabled=false;
            

            foreach (var secim in groupBox1.Controls)
            {
                if (secim is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            foreach (var secim2 in groupBox2.Controls)
            {
                if (secim2 is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            listBox2.Items.Clear();
            servis_edilen_lüle++;
            listBox2.Items.Add("Toplam Servis Edilen Lüle Sayısı: "+servis_edilen_lüle);
            listBox2.Items.Add("------------------------------------------------------");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
