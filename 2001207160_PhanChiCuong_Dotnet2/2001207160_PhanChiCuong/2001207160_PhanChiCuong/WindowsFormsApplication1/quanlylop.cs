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
using System.Data;
namespace WindowsFormsApplication1
{
    public partial class quanlulop : Form
    {
        DataSet ds;
        DBconnect conn;
        SqlDataAdapter ada_lop;
        DataColumn[] primaryKey;
       

        public quanlulop()
        {
            InitializeComponent();
            conn = new DBconnect();
            primaryKey = new DataColumn[1];
            ds = new DataSet();
            ada_lop = new SqlDataAdapter();
        }

       private void LoadKhoa_ComboBox()
        {
            string strselect = "select * from Khoa";
            SqlDataAdapter ada = new SqlDataAdapter(strselect,conn.StrConnect);
            ada.Fill(ds, "KHOA");
            cbx_khoa.DataSource = ds.Tables[0];
            cbx_khoa.DisplayMember = "TENKHOA";
            cbx_khoa.ValueMember = "MAKHOA";
            
            
        }

        private void quanlylop_Load(object sender, EventArgs e)
        {
            LoadKhoa_ComboBox();
        }
        
        public bool KT_KhoaChinh(String pMa)
        {
            string selectStirng = "select * from Lop where Malop ='" + pMa + "'";
            SqlCommand cmd = new SqlCommand(selectStirng);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Close();
                return false;

            }
            else
            {
                rd.Close();
                return true;
            }
        }

        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if(KT_KhoaChinh(txt_tenlop.Text)==true)
        //        {
        //            string insertString;
        //            insertString = "insert into Lop values('" + txt_tenlop.Text + "',N'" + txt_makhoa.s + "')";
        //            SqlCommand cmd = new SqlCommand(insertString);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Thanh cong");
        //        }
        //        else { MessageBox.Show("Trung ma Khoa"); }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("That bai");
        //    }
        //}
       
    }
}
