using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mencari_Elemen_Array
{
    public partial class Form1 : Form
    {

        string[] nama = new string[] { "Marhen", "Tono", "Andi", "Riko", "Juni" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nama.Length; i++)
            {
                lBNama.Items.Add(nama[i]);
            }
        }

        private void bTTampil_Click(object sender, EventArgs e)
        {
            if (tBIndex.Text == "")
            {
                MessageBox.Show("Kolom Index Tidak Boleh Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int index;
                index = Convert.ToInt32(tBIndex.Text);
                if (index < 0 || index > (nama.Length - 1))
                {
                    MessageBox.Show("Tidak Ada Elemen Array Yang Ditemukan", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Elemen Array Pada Index Ke-"+index+" Adalah: "+nama[index], "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                        
            tBIndex.Text = "";
            tBIndex.Focus();
            
        }
    }
}
