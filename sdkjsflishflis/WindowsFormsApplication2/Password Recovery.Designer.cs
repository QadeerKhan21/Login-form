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
            this.label4 = new System.Windows.Forms.Label();
            this.textAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Q = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.groupSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSignUp
            // 
            this.groupSignUp.Controls.Add(this.label4);
            this.groupSignUp.Controls.Add(this.textAns);
            this.groupSignUp.Controls.Add(this.label3);
            this.groupSignUp.Controls.Add(this.combo_Q);
            this.groupSignUp.Controls.Add(this.linkLabel1);
            this.groupSignUp.Controls.Add(this.label2);
            this.groupSignUp.Controls.Add(this.textpass);
            this.groupSignUp.Controls.Add(this.btnSignUp);
            this.groupSignUp.Controls.Add(this.label1);
            this.groupSignUp.Controls.Add(this.textuser);
            this.groupSignUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSignUp.Location = new System.Drawing.Point(59, 53);
            this.groupSignUp.Name = "groupSignUp";
            this.groupSignUp.Size = new System.Drawing.Size(271, 334);
            this.groupSignUp.TabIndex = 2;
            this.groupSignUp.TabStop = false;
            this.groupSignUp.Text = "SignUp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Answer";
            // 
            // textAns
            // 
            this.textAns.Location = new System.Drawing.Point(113, 144);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(133, 25);
            this.textAns.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Secret Q";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // combo_Q
            // 
            this.combo_Q.FormattingEnabled = true;
            this.combo_Q.Items.AddRange(new object[] {
            "favourite star",
            "crush",
            "film actress"});
            this.combo_Q.Location = new System.Drawing.Point(113, 110);
            this.combo_Q.Name = "combo_Q";
            this.combo_Q.Size = new System.Drawing.Size(134, 25);
            this.combo_Q.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(201, 302);
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
            this.label2.Location = new System.Drawing.Point(19, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Pass";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(112, 180);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(134, 25);
            this.textpass.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(32, 236);
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
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(113, 68);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(134, 25);
            this.textuser.TabIndex = 0;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Q;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAns;
    }
}