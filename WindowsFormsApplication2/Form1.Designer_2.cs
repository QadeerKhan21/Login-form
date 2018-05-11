namespace WindowsFormsApplication2
{
    partial class FormL
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
            this.cmdlogin = new System.Windows.Forms.Button();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.lnkloginform = new System.Windows.Forms.Label();
            this.lnk_sign = new System.Windows.Forms.LinkLabel();
            this.textlpwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdlogin
            // 
            this.cmdlogin.Location = new System.Drawing.Point(180, 145);
            this.cmdlogin.Name = "cmdlogin";
            this.cmdlogin.Size = new System.Drawing.Size(75, 25);
            this.cmdlogin.TabIndex = 0;
            this.cmdlogin.Text = "login";
            this.cmdlogin.UseVisualStyleBackColor = true;
            this.cmdlogin.Click += new System.EventHandler(this.cmdlogin_Click);
            // 
            // Txtusername
            // 
            this.Txtusername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txtusername.Location = new System.Drawing.Point(116, 68);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(139, 22);
            this.Txtusername.TabIndex = 1;
            // 
            // lnkloginform
            // 
            this.lnkloginform.AutoSize = true;
            this.lnkloginform.Location = new System.Drawing.Point(44, 72);
            this.lnkloginform.Name = "lnkloginform";
            this.lnkloginform.Size = new System.Drawing.Size(56, 14);
            this.lnkloginform.TabIndex = 2;
            this.lnkloginform.Text = "username";
            // 
            // lnk_sign
            // 
            this.lnk_sign.AutoSize = true;
            this.lnk_sign.Location = new System.Drawing.Point(44, 155);
            this.lnk_sign.Name = "lnk_sign";
            this.lnk_sign.Size = new System.Drawing.Size(43, 14);
            this.lnk_sign.TabIndex = 3;
            this.lnk_sign.TabStop = true;
            this.lnk_sign.Text = "Sign up";
            this.lnk_sign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_sign_LinkClicked);
            // 
            // textlpwd
            // 
            this.textlpwd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textlpwd.Location = new System.Drawing.Point(116, 98);
            this.textlpwd.Name = "textlpwd";
            this.textlpwd.PasswordChar = '&';
            this.textlpwd.Size = new System.Drawing.Size(139, 22);
            this.textlpwd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 35);
            this.panel1.TabIndex = 6;
            this.panel1.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(77, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 17);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " Enter your Info below";
            // 
            // FormL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(322, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textlpwd);
            this.Controls.Add(this.lnk_sign);
            this.Controls.Add(this.lnkloginform);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.cmdlogin);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormL";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdlogin;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.Label lnkloginform;
        private System.Windows.Forms.LinkLabel lnk_sign;
        private System.Windows.Forms.TextBox textlpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

