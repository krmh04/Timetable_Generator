using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_Generator
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Timetable_generator.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        SqlDataAdapter sda = new SqlDataAdapter();
        private void btn_add_click(object sender, EventArgs e)
        {
            string query = "insert into CourseTable values(@id,@name,@lectures)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_cs_id.Text));
            cmd.Parameters.AddWithValue("@name", txt_cs_box.Text);
            cmd.Parameters.AddWithValue("@lectures", Convert.ToInt32(txt_lectures.Text));

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Inserted Data Successfully");
         }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "update CourseTable set Course_Id=@id,C_Name=@name,No_Lectures=@lectures where Course_Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_cs_id.Text));
            cmd.Parameters.AddWithValue("@name", txt_cs_box.Text);
            cmd.Parameters.AddWithValue("@lectures", Convert.ToInt32(txt_lectures.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = "delete CourseTable where Course_Id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_cs_id.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Data Deleted Successfully");
        }
    }
    
}
