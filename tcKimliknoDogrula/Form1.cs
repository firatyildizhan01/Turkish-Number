using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcKimliknoDogrula
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

        private void button1_Click(object sender, EventArgs e)
        {
            tcKimlikNo.KPSPublic kps = new tcKimlikNo.KPSPublic();
            bool kontrol = kps.TCKimlikNoDogrula(long.Parse(txtTc.Text), txtisim.Text.ToUpper(), txtSoyisim.Text.ToUpper(), int.Parse(txtDoğum.Text));
            if (kontrol)
            {
                MessageBox.Show("bilgilerini doğrulandı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("bilgilerini doğrulanmadı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
