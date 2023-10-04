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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.InitialDirectory = "D\\";
            open_dialog.Filter = "Text files (*.docx)|*.doc|All docx (*.*)|*.*";
            open_dialog.ShowDialog();

            //Form2 frm = new Form2();
            //frm.ShowDialog();
        }
    }
}
