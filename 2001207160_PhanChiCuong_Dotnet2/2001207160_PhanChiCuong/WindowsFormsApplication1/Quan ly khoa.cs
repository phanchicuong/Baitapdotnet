using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Quan_ly_khoa : Form
    {
        public Quan_ly_khoa()
        {
            InitializeComponent();
        }

        private void Quan_ly_khoa_Load(object sender, EventArgs e)
        {

        }
        bool KT_MaKhoa(String ma)
        {
            try
            {
                string selectString = "select count (*) from Khoa where MaKhoa = '" + ma + "'";
                SqlCommand cmd = new SqlCommand(selectString);
                int count = (int)cmd.ExecuteScalar();
                if (count >= 1)
                    return false;
                return true;
            }
            catch (Exception ex) { return false; }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
          try
          {
              if(KT_MaKhoa(txt_makhoa.Text)==true)
              {
                  string insertString;
                  insertString = "insert into Khoa values('" + txt_makhoa.Text + "',N'" + txt_tenkhoa.Text + "')";
                  SqlCommand cmd = new SqlCommand(insertString);
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Thanh cong");
              }
              else { MessageBox.Show("Trung ma khoa"); }
          }
          catch (Exception ex)
          {
              MessageBox.Show("That bai");
          }
        }
    }
}
