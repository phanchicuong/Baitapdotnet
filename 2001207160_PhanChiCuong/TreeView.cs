using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207120_MaiNgocKhang_Tuan06
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

      
       
        public bool kiemtra(string s)
        {
            if (string.Compare(s, treeView1.SelectedNode.Text, true) == 0)
                return true;
            return false;
        }
        private void btn_Thempban_Click(object sender, EventArgs e)
        {
            if(kiemtra(txt_phongb.Text)==false)
            {
                treeView1.Nodes.Add(txt_phongb.Text);
                cbx_phongban.Items.Add(txt_phongb.Text);
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại!");
            }
            txt_phongb.Text = "";
            txt_phongb.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                if(treeView1.SelectedNode!=null)
                {
                    cbx_phongban.Items.Remove(treeView1.SelectedNode.Text);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(TreeNode node in treeView1.Nodes)
                if(node.Text==cbx_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            treeView1.Nodes[index].Nodes.Add(txt_hoten.Text + "(" + txt_maso.Text + ")");
            treeView1.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
            foreach (string s in pb)
            {
                treeView1.Nodes.Add(s);
                cbx_phongban.Items.Add(s);
            }
            cbx_phongban.SelectedIndex = 0;
        }

        private void TreeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Thoát", "Bạn có muốn Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult)
            {
                e.Cancel = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
