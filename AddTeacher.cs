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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
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

        private void btn_update_click(object sender, EventArgs e)
        {
            string query = "update TeacherTable set Teacher_Id=@id,Name=@name where Teacher_Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id_box.Text));
            cmd.Parameters.AddWithValue("@name", txt_teac_name.Text);
             con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Data Updated Successfully");
        }

        private void btn_t_delete_Click(object sender, EventArgs e)
        {
            string query = "delete TeacherTable where Teacher_Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id_box.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Data Deleted Successfully");
        }
    }
}
