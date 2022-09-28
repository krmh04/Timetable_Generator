using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TimeTable_Generator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void gen_btn_click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30";
            

        }
    }
}
