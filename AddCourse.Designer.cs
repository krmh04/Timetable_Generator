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
            this.txt_cs_box = new System.Windows.Forms.TextBox();
            this.btn_cs_add = new System.Windows.Forms.Button();
            this.lbl_lectures = new System.Windows.Forms.Label();
            this.txt_lectures = new System.Windows.Forms.TextBox();
            this.txt_cs_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            // txt_cs_box
            // 
            this.txt_cs_box.Location = new System.Drawing.Point(328, 113);
            this.txt_cs_box.Name = "txt_cs_box";
            this.txt_cs_box.Size = new System.Drawing.Size(120, 22);
            this.txt_cs_box.TabIndex = 2;
            // 
            // btn_cs_add
            // 
            this.btn_cs_add.Location = new System.Drawing.Point(247, 256);
            this.btn_cs_add.Name = "btn_cs_add";
            this.btn_cs_add.Size = new System.Drawing.Size(75, 23);
            this.btn_cs_add.TabIndex = 4;
            this.btn_cs_add.Text = "Add";
            this.btn_cs_add.UseVisualStyleBackColor = true;
            this.btn_cs_add.Click += new System.EventHandler(this.btn_add_click);
            // 
            // lbl_lectures
            // 
            this.lbl_lectures.AutoSize = true;
            this.lbl_lectures.Location = new System.Drawing.Point(175, 182);
            this.lbl_lectures.Name = "lbl_lectures";
            this.lbl_lectures.Size = new System.Drawing.Size(89, 16);
            this.lbl_lectures.TabIndex = 5;
            this.lbl_lectures.Text = "No of lectures";
            // 
            // txt_lectures
            // 
            this.txt_lectures.Location = new System.Drawing.Point(328, 176);
            this.txt_lectures.Name = "txt_lectures";
            this.txt_lectures.Size = new System.Drawing.Size(133, 22);
            this.txt_lectures.TabIndex = 7;
            // 
            // txt_cs_id
            // 
            this.txt_cs_id.Location = new System.Drawing.Point(328, 70);
            this.txt_cs_id.Name = "txt_cs_id";
            this.txt_cs_id.Size = new System.Drawing.Size(120, 22);
            this.txt_cs_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course ID";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(370, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(508, 255);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cs_id);
            this.Controls.Add(this.txt_lectures);
            this.Controls.Add(this.lbl_lectures);
            this.Controls.Add(this.btn_cs_add);
            this.Controls.Add(this.txt_cs_box);
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
        private System.Windows.Forms.TextBox txt_cs_box;
        private System.Windows.Forms.Button btn_cs_add;
        private System.Windows.Forms.Label lbl_lectures;
        private System.Windows.Forms.TextBox txt_lectures;
        private System.Windows.Forms.TextBox txt_cs_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}