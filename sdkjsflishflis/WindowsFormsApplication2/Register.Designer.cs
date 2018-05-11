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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.groupSignUp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAns = new System.Windows.Forms.TextBox();
            this.Secret = new System.Windows.Forms.Label();
            this.combo_Q = new System.Windows.Forms.ComboBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.groupSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSignUp
            // 
            this.groupSignUp.Controls.Add(this.label3);
            this.groupSignUp.Controls.Add(this.textAns);
            this.groupSignUp.Controls.Add(this.Secret);
            this.groupSignUp.Controls.Add(this.combo_Q);
            this.groupSignUp.Controls.Add(this.btnSignUp);
            this.groupSignUp.Controls.Add(this.btnSignIN);
            this.groupSignUp.Controls.Add(this.label2);
            this.groupSignUp.Controls.Add(this.label1);
            this.groupSignUp.Controls.Add(this.textpass);
            this.groupSignUp.Controls.Add(this.textuser);
            this.groupSignUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSignUp.Location = new System.Drawing.Point(56, 56);
            this.groupSignUp.Name = "groupSignUp";
            this.groupSignUp.Size = new System.Drawing.Size(271, 334);
            this.groupSignUp.TabIndex = 1;
            this.groupSignUp.TabStop = false;
            this.groupSignUp.Text = "SignUp";
            this.groupSignUp.Enter += new System.EventHandler(this.groupSignUp_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer";
            // 
            // textAns
            // 
            this.textAns.Location = new System.Drawing.Point(113, 178);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(134, 25);
            this.textAns.TabIndex = 6;
            // 
            // Secret
            // 
            this.Secret.AutoSize = true;
            this.Secret.Location = new System.Drawing.Point(26, 154);
            this.Secret.Name = "Secret";
            this.Secret.Size = new System.Drawing.Size(61, 17);
            this.Secret.TabIndex = 5;
            this.Secret.Text = "Secret Q";
            this.Secret.Click += new System.EventHandler(this.Secret_Click);
            // 
            // combo_Q
            // 
            this.combo_Q.FormattingEnabled = true;
            this.combo_Q.Items.AddRange(new object[] {
            "favourite star",
            "crush",
            "film actress"});
            this.combo_Q.Location = new System.Drawing.Point(113, 146);
            this.combo_Q.Name = "combo_Q";
            this.combo_Q.Size = new System.Drawing.Size(134, 25);
            this.combo_Q.TabIndex = 4;
            this.combo_Q.SelectedIndexChanged += new System.EventHandler(this.combo_Q_SelectedIndexChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(32, 228);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(215, 37);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIN
            // 
            this.btnSignIN.Location = new System.Drawing.Point(32, 271);
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
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(113, 110);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(134, 25);
            this.textpass.TabIndex = 1;
            this.textpass.TextChanged += new System.EventHandler(this.textpass_TextChanged);
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(113, 68);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(134, 25);
            this.textuser.TabIndex = 0;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 468);
            this.Controls.Add(this.groupSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.groupSignUp.ResumeLayout(false);
            this.groupSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label Secret;
        private System.Windows.Forms.ComboBox combo_Q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAns;
    }
}