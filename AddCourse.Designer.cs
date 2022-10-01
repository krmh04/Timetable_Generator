namespace TimeTable_Generator
{
    partial class AddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_crs_add = new System.Windows.Forms.Label();
            this.lbl_sb_add = new System.Windows.Forms.Label();
            this.txt_cs_box = new System.Windows.Forms.TextBox();
            this.comboBox_sb = new System.Windows.Forms.ComboBox();
            this.btn_cs_add = new System.Windows.Forms.Button();
            this.lbl_lectures = new System.Windows.Forms.Label();
            this.cb_lectures = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_crs_add
            // 
            this.lbl_crs_add.AutoSize = true;
            this.lbl_crs_add.Location = new System.Drawing.Point(175, 113);
            this.lbl_crs_add.Name = "lbl_crs_add";
            this.lbl_crs_add.Size = new System.Drawing.Size(90, 16);
            this.lbl_crs_add.TabIndex = 0;
            this.lbl_crs_add.Text = "Course Name";
            // 
            // lbl_sb_add
            // 
            this.lbl_sb_add.AutoSize = true;
            this.lbl_sb_add.Location = new System.Drawing.Point(175, 197);
            this.lbl_sb_add.Name = "lbl_sb_add";
            this.lbl_sb_add.Size = new System.Drawing.Size(92, 16);
            this.lbl_sb_add.TabIndex = 1;
            this.lbl_sb_add.Text = "No of subjects";
            // 
            // txt_cs_box
            // 
            this.txt_cs_box.Location = new System.Drawing.Point(337, 113);
            this.txt_cs_box.Name = "txt_cs_box";
            this.txt_cs_box.Size = new System.Drawing.Size(100, 22);
            this.txt_cs_box.TabIndex = 2;
            // 
            // comboBox_sb
            // 
            this.comboBox_sb.FormattingEnabled = true;
            this.comboBox_sb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_sb.Location = new System.Drawing.Point(328, 197);
            this.comboBox_sb.Name = "comboBox_sb";
            this.comboBox_sb.Size = new System.Drawing.Size(121, 24);
            this.comboBox_sb.TabIndex = 3;
            // 
            // btn_cs_add
            // 
            this.btn_cs_add.Location = new System.Drawing.Point(328, 315);
            this.btn_cs_add.Name = "btn_cs_add";
            this.btn_cs_add.Size = new System.Drawing.Size(75, 23);
            this.btn_cs_add.TabIndex = 4;
            this.btn_cs_add.Text = "Add";
            this.btn_cs_add.UseVisualStyleBackColor = true;
            // 
            // lbl_lectures
            // 
            this.lbl_lectures.AutoSize = true;
            this.lbl_lectures.Location = new System.Drawing.Point(175, 254);
            this.lbl_lectures.Name = "lbl_lectures";
            this.lbl_lectures.Size = new System.Drawing.Size(89, 16);
            this.lbl_lectures.TabIndex = 5;
            this.lbl_lectures.Text = "No of lectures";
            // 
            // cb_lectures
            // 
            this.cb_lectures.FormattingEnabled = true;
            this.cb_lectures.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_lectures.Location = new System.Drawing.Point(328, 249);
            this.cb_lectures.Name = "cb_lectures";
            this.cb_lectures.Size = new System.Drawing.Size(121, 24);
            this.cb_lectures.TabIndex = 6;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_lectures);
            this.Controls.Add(this.lbl_lectures);
            this.Controls.Add(this.btn_cs_add);
            this.Controls.Add(this.comboBox_sb);
            this.Controls.Add(this.txt_cs_box);
            this.Controls.Add(this.lbl_sb_add);
            this.Controls.Add(this.lbl_crs_add);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_crs_add;
        private System.Windows.Forms.Label lbl_sb_add;
        private System.Windows.Forms.TextBox txt_cs_box;
        private System.Windows.Forms.ComboBox comboBox_sb;
        private System.Windows.Forms.Button btn_cs_add;
        private System.Windows.Forms.Label lbl_lectures;
        private System.Windows.Forms.ComboBox cb_lectures;
    }
}