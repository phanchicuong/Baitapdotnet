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
    public partial class quanlylop : Form
    {
        public quanlylop()
        {
            InitializeComponent();
        }

        private void cbx_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string selectString = "select * from Khoa";
           
            SqlCommand cmd = new SqlCommand(selectString,);
            
            SqlDataReader rd = cmd.ExecuteReader();
         
            while (rd.Read())
            {
               cbx_khoa.Items.Add(rd["MaKhoa"].ToString());
            }
            rd.Close();
          
        }

        private void quanlylop_Load(object sender, EventArgs e)
        {
            cbx_khoa_SelectedIndexChanged();
        }
    }
}
