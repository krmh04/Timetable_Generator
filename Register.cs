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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Timetable_generator.mdf;Integrated Security=True;Connect Timeout=30");
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
            

            if (re_pwd_box.Text != string.Empty || txt_box_pwd.Text != string.Empty || txt_box_uname.Text != string.Empty)
            {
                if (txt_box_pwd.Text == re_pwd_box.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("select * from LoginTable where username='" + txt_box_uname.Text + "'", con);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        sdr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sdr.Close();
                          cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", txt_box_uname.Text);
                        cmd.Parameters.AddWithValue("password", txt_box_pwd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login f = new Login();
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            //String q = "insert into Register values(@username,@password)";

            //cmd.Parameters.AddWithValue("@name", txt_box_uname.Text);
            //cmd.Parameters.AddWithValue("@password", txt_pwd.Text);

            //if (txt_pwd.Text == re_pwd_box.Text)
            //{
            //    con.Open();
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)
            //        MessageBox.Show("Registered Successfully");
            //    this.Hide();
            //    Login f = new Login();
            //    f.ShowDialog();
            //}
            //else
            //{
            //    DialogResult result=MessageBox.Show("Passwords do not match🙁", "Password",
            //    MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            //    if (result == DialogResult.Retry)
            //    {
            //        Register f = new Register();
            //        f.ShowDialog();

            //    }
            //    else
            //    {
            //        Close();
            //    }
            //}
        }
    }
}
