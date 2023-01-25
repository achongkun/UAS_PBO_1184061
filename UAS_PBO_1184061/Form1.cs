using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PBO_1184061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 prodi = new Form2();
            prodi.Show();
            this.Hide();
        }

        private void daftarUlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 daftarUlang = new Form3();
            daftarUlang.Show();
            this.Hide();
        }
    }
}
