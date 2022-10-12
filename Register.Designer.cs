namespace TimeTable_Generator
{
    partial class Register
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
            this.txt_uname = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.Label();
            this.txt_box_uname = new System.Windows.Forms.TextBox();
            this.txt_box_pwd = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.lgn_ch_lbl = new System.Windows.Forms.Label();
            this.lgn_lbl = new System.Windows.Forms.Label();
            this.pwd_reen_lbl = new System.Windows.Forms.Label();
            this.txt_re_pwd_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_uname
            // 
            this.txt_uname.AutoSize = true;
            this.txt_uname.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.txt_uname.Location = new System.Drawing.Point(115, 114);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(79, 21);
            this.txt_uname.TabIndex = 0;
            this.txt_uname.Text = "Username";
            // 
            // txt_pwd
            // 
            this.txt_pwd.AutoSize = true;
            this.txt_pwd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.txt_pwd.Location = new System.Drawing.Point(120, 227);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(74, 21);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.Text = "Password";
            // 
            // txt_box_uname
            // 
            this.txt_box_uname.Location = new System.Drawing.Point(274, 115);
            this.txt_box_uname.Name = "txt_box_uname";
            this.txt_box_uname.Size = new System.Drawing.Size(154, 22);
            this.txt_box_uname.TabIndex = 2;
            // 
            // txt_box_pwd
            // 
            this.txt_box_pwd.Location = new System.Drawing.Point(274, 227);
            this.txt_box_pwd.Name = "txt_box_pwd";
            this.txt_box_pwd.PasswordChar = '*';
            this.txt_box_pwd.Size = new System.Drawing.Size(154, 22);
            this.txt_box_pwd.TabIndex = 3;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(309, 357);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(83, 32);
            this.reg_btn.TabIndex = 4;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // lgn_ch_lbl
            // 
            this.lgn_ch_lbl.AutoSize = true;
            this.lgn_ch_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_ch_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.lgn_ch_lbl.Location = new System.Drawing.Point(179, 413);
            this.lgn_ch_lbl.Name = "lgn_ch_lbl";
            this.lgn_ch_lbl.Size = new System.Drawing.Size(231, 20);
            this.lgn_ch_lbl.TabIndex = 5;
            this.lgn_ch_lbl.Text = "Already have an account ?";
            // 
            // lgn_lbl
            // 
            this.lgn_lbl.AutoSize = true;
            this.lgn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.lgn_lbl.Location = new System.Drawing.Point(416, 411);
            this.lgn_lbl.Name = "lgn_lbl";
            this.lgn_lbl.Size = new System.Drawing.Size(110, 22);
            this.lgn_lbl.TabIndex = 6;
            this.lgn_lbl.Text = "Login Now!";
            this.lgn_lbl.Click += new System.EventHandler(this.login_check);
            // 
            // pwd_reen_lbl
            // 
            this.pwd_reen_lbl.AutoSize = true;
            this.pwd_reen_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_reen_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.pwd_reen_lbl.Location = new System.Drawing.Point(120, 293);
            this.pwd_reen_lbl.Name = "pwd_reen_lbl";
            this.pwd_reen_lbl.Size = new System.Drawing.Size(137, 21);
            this.pwd_reen_lbl.TabIndex = 8;
            this.pwd_reen_lbl.Text = "Reenter password";
            // 
            // txt_re_pwd_box
            // 
            this.txt_re_pwd_box.Location = new System.Drawing.Point(274, 293);
            this.txt_re_pwd_box.Name = "txt_re_pwd_box";
            this.txt_re_pwd_box.PasswordChar = '*';
            this.txt_re_pwd_box.Size = new System.Drawing.Size(154, 22);
            this.txt_re_pwd_box.TabIndex = 9;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_re_pwd_box);
            this.Controls.Add(this.pwd_reen_lbl);
            this.Controls.Add(this.lgn_lbl);
            this.Controls.Add(this.lgn_ch_lbl);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.txt_box_pwd);
            this.Controls.Add(this.txt_box_uname);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uname);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_uname;
        private System.Windows.Forms.Label txt_pwd;
        private System.Windows.Forms.TextBox txt_box_uname;
        private System.Windows.Forms.TextBox txt_box_pwd;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label lgn_ch_lbl;
        private System.Windows.Forms.Label lgn_lbl;
        private System.Windows.Forms.Label pwd_reen_lbl;
        private System.Windows.Forms.TextBox txt_re_pwd_box;
    }
}