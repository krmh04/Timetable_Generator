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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void login_check(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30";
            String q = "insert into Register values(@username,@password)";

            cmd.Parameters.AddWithValue("@name", txt_box_uname.Text);
            cmd.Parameters.AddWithValue("@password", txt_pwd.Text);

            if (txt_pwd.Text == re_pwd_box.Text)
            {
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registered Successfully");
            }
            else
            {
                DialogResult result=MessageBox.Show("Passwords do not match🙁", "Password",
                                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Retry)
                {
                    InitializeComponent();
                  }
                else
                {
                    Close();
                }
            }
        }
    }
}
