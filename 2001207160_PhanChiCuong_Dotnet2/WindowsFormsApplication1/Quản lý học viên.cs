using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nhậpHọcViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhập_học_viên_mới frm = new Nhập_học_viên_mới();
            frm.ShowDialog();
        }

        private void chuyểnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst_A.Items.Add(lst_B.SelectedItem);
            lst_A.Items.Remove(lst_A.SelectedItem);
        }

        private void chuyểnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst_B.Items.Add(lst_A.SelectedItem);
            lst_B.Items.Remove(lst_B.SelectedItem);
        }
    }
}
