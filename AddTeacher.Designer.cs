namespace TimeTable_Generator
{
    partial class AddTeacher
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
            this.txt_teac_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_box = new System.Windows.Forms.TextBox();
            this.btn_t_update = new System.Windows.Forms.Button();
            this.btn_t_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_teac_name
            // 
            this.txt_teac_name.Location = new System.Drawing.Point(389, 122);
            this.txt_teac_name.Name = "txt_teac_name";
            this.txt_teac_name.Size = new System.Drawing.Size(121, 22);
            this.txt_teac_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(221, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher\'s name";
            // 
            // generate_btn
            // 
            this.generate_btn.Location = new System.Drawing.Point(170, 189);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(115, 23);
            this.generate_btn.TabIndex = 4;
            this.generate_btn.Text = "Add teacher";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.gen_btn_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(224, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teacher\'s ID";
            // 
            // txt_id_box
            // 
            this.txt_id_box.Location = new System.Drawing.Point(389, 68);
            this.txt_id_box.Name = "txt_id_box";
            this.txt_id_box.Size = new System.Drawing.Size(121, 22);
            this.txt_id_box.TabIndex = 6;
            // 
            // btn_t_update
            // 
            this.btn_t_update.Location = new System.Drawing.Point(333, 189);
            this.btn_t_update.Name = "btn_t_update";
            this.btn_t_update.Size = new System.Drawing.Size(110, 23);
            this.btn_t_update.TabIndex = 7;
            this.btn_t_update.Text = "Update Details";
            this.btn_t_update.UseVisualStyleBackColor = true;
            this.btn_t_update.Click += new System.EventHandler(this.btn_update_click);
            // 
            // btn_t_delete
            // 
            this.btn_t_delete.Location = new System.Drawing.Point(488, 189);
            this.btn_t_delete.Name = "btn_t_delete";
            this.btn_t_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_t_delete.TabIndex = 8;
            this.btn_t_delete.Text = "Delete";
            this.btn_t_delete.UseVisualStyleBackColor = true;
            this.btn_t_delete.Click += new System.EventHandler(this.btn_t_delete_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_t_delete);
            this.Controls.Add(this.btn_t_update);
            this.Controls.Add(this.txt_id_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teac_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeacher";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_teac_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_box;
        private System.Windows.Forms.Button btn_t_update;
        private System.Windows.Forms.Button btn_t_delete;
    }
}