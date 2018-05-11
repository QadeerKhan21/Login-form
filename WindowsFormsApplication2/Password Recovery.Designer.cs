namespace WindowsFormsApplication2
{
    partial class Password_Recovery
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
            this.groupSignUp = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAns = new System.Windows.Forms.TextBox();
            this.combo_q = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSignUp
            // 
            this.groupSignUp.Controls.Add(this.label4);
            this.groupSignUp.Controls.Add(this.textAns);
            this.groupSignUp.Controls.Add(this.combo_q);
            this.groupSignUp.Controls.Add(this.label3);
            this.groupSignUp.Controls.Add(this.linkLabel1);
            this.groupSignUp.Controls.Add(this.label2);
            this.groupSignUp.Controls.Add(this.textpass);
            this.groupSignUp.Controls.Add(this.btnSignUp);
            this.groupSignUp.Controls.Add(this.label1);
            this.groupSignUp.Controls.Add(this.textuser);
            this.groupSignUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSignUp.Location = new System.Drawing.Point(30, 53);
            this.groupSignUp.Name = "groupSignUp";
            this.groupSignUp.Size = new System.Drawing.Size(316, 365);
            this.groupSignUp.TabIndex = 2;
            this.groupSignUp.TabStop = false;
            this.groupSignUp.Text = "SignUp";
            this.groupSignUp.Enter += new System.EventHandler(this.groupSignUp_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(239, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SignIn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Pass";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textpass
            // 
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpass.Location = new System.Drawing.Point(150, 194);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(134, 25);
            this.textpass.TabIndex = 5;
            this.textpass.TextChanged += new System.EventHandler(this.textpass_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(70, 246);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(215, 37);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Recover";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textuser
            // 
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textuser.Location = new System.Drawing.Point(151, 54);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(134, 25);
            this.textuser.TabIndex = 0;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Answer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textAns
            // 
            this.textAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAns.Location = new System.Drawing.Point(150, 142);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(134, 25);
            this.textAns.TabIndex = 12;
            this.textAns.TextChanged += new System.EventHandler(this.textAns_TextChanged);
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
            this.combo_q.Location = new System.Drawing.Point(150, 99);
            this.combo_q.Name = "combo_q";
            this.combo_q.Size = new System.Drawing.Size(134, 25);
            this.combo_q.TabIndex = 11;
            this.combo_q.UseWaitCursor = true;
            this.combo_q.SelectedIndexChanged += new System.EventHandler(this.combo_q_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Secret Question";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 465);
            this.Controls.Add(this.groupSignUp);
            this.Name = "Password_Recovery";
            this.Text = "Password_Recovery";
            this.groupSignUp.ResumeLayout(false);
            this.groupSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAns;
        private System.Windows.Forms.ComboBox combo_q;
        private System.Windows.Forms.Label label3;
    }
}