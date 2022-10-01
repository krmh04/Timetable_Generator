using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable_Generator
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void add_course_click(object sender, EventArgs e)
        {
            loadform(new AddCourse());
        }

        private void add_teacher_click(object sender, EventArgs e)
        {
            loadform(new AddTeacher());

        }

        private void btn_generate_click(object sender, EventArgs e)
        {
            loadform(new MainView());

        }

        private void btn_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
