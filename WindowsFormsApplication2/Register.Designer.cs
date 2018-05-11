namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.groupSignUp = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAns = new System.Windows.Forms.TextBox();
            this.combo_q = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSignUp
            // 
            this.groupSignUp.Controls.Add(this.checkBox1);
            this.groupSignUp.Controls.Add(this.label4);
            this.groupSignUp.Controls.Add(this.textAns);
            this.groupSignUp.Controls.Add(this.combo_q);
            this.groupSignUp.Controls.Add(this.label3);
            this.groupSignUp.Controls.Add(this.btnSignUp);
            this.groupSignUp.Controls.Add(this.btnSignIN);
            this.groupSignUp.Controls.Add(this.label2);
            this.groupSignUp.Controls.Add(this.label1);
            this.groupSignUp.Controls.Add(this.textpass);
            this.groupSignUp.Controls.Add(this.textuser);
            this.groupSignUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSignUp.Location = new System.Drawing.Point(40, 34);
            this.groupSignUp.Name = "groupSignUp";
            this.groupSignUp.Size = new System.Drawing.Size(310, 389);
            this.groupSignUp.TabIndex = 1;
            this.groupSignUp.TabStop = false;
            this.groupSignUp.Text = "SignUp";
            this.groupSignUp.Enter += new System.EventHandler(this.groupSignUp_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Agree to terms";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Answer";
            // 
            // textAns
            // 
            this.textAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAns.Location = new System.Drawing.Point(126, 197);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(134, 25);
            this.textAns.TabIndex = 6;
            // 
            // combo_q
            // 
            this.combo_q.AllowDrop = true;
            this.combo_q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_q.FormattingEnabled = true;
            this.combo_q.Items.AddRange(new object[] {
            "Name of first class teacher?",
            "Name of you pet?",
            "Mother birth place?",
            "last of fours digits of your phone number?"});
            this.combo_q.Location = new System.Drawing.Point(126, 154);
            this.combo_q.Name = "combo_q";
            this.combo_q.Size = new System.Drawing.Size(134, 25);
            this.combo_q.TabIndex = 5;
            this.combo_q.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Secret Question";
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(35, 284);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(215, 37);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIN
            // 
            this.btnSignIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIN.Location = new System.Drawing.Point(35, 327);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(215, 37);
            this.btnSignIN.TabIndex = 1;
            this.btnSignIN.Text = "Sign In";
            this.btnSignIN.UseVisualStyleBackColor = true;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textpass
            // 
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpass.Location = new System.Drawing.Point(126, 110);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(134, 25);
            this.textpass.TabIndex = 1;
            this.textpass.TextChanged += new System.EventHandler(this.textpass_TextChanged);
            // 
            // textuser
            // 
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textuser.Location = new System.Drawing.Point(126, 68);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(134, 25);
            this.textuser.TabIndex = 0;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltime.Location = new System.Drawing.Point(269, 446);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 13);
            this.lbltime.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 468);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupSignUp.ResumeLayout(false);
            this.groupSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.ComboBox combo_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
    }
}