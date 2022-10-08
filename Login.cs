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
    public partial class Login : Form
    {
        public Login()
        {
            BackColor = Color.FromArgb(82, 111, 190);
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Timetable_generator.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void btn_login_Click(object sender, EventArgs e)
        {
 
            if (txt_pwd.Text != string.Empty || txt_uname.Text != string.Empty)
            {
                con.Open();
                cmd = new SqlCommand("select * from LoginTable where username='" + txt_uname.Text + "' and password='" + txt_pwd.Text + "'", con);
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    this.Hide();
                    Dashboard f = new Dashboard();
                    f.ShowDialog();
                    con.Close();

                }
                else
                {
                    sdr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.ShowDialog();
        }
    }
}
