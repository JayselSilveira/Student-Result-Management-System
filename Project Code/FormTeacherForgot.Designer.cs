namespace Mini_Project_2
{
    partial class FormTeacherForgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherForgot));
            this.btnLoginP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginP
            // 
            this.btnLoginP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginP.ForeColor = System.Drawing.Color.Coral;
            this.btnLoginP.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginP.Image")));
            this.btnLoginP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginP.Location = new System.Drawing.Point(862, 846);
            this.btnLoginP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginP.Name = "btnLoginP";
            this.btnLoginP.Size = new System.Drawing.Size(346, 69);
            this.btnLoginP.TabIndex = 4;
            this.btnLoginP.Text = "  Login Page";
            this.btnLoginP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginP.UseVisualStyleBackColor = true;
            this.btnLoginP.Click += new System.EventHandler(this.btnLoginP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Email Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(581, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Sent Passcode:";
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(1055, 176);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(4);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(320, 41);
            this.txtemailid.TabIndex = 7;
            // 
            // textcode
            // 
            this.textcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcode.Location = new System.Drawing.Point(1055, 438);
            this.textcode.Margin = new System.Windows.Forms.Padding(4);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(320, 41);
            this.textcode.TabIndex = 8;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.Coral;
            this.btnEmail.Location = new System.Drawing.Point(1183, 259);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(307, 65);
            this.btnEmail.TabIndex = 9;
            this.btnEmail.Text = "Send Passcode";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnCode
            // 
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.ForeColor = System.Drawing.Color.Coral;
            this.btnCode.Location = new System.Drawing.Point(1183, 518);
            this.btnCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(307, 63);
            this.btnCode.TabIndex = 10;
            this.btnCode.Text = "Confirm";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "FORGOT PASSWORD PAGE";
            // 
            // FormTeacherForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Mini_Project_2.Properties.Resources.don_bosco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.textcode);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTeacherForgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacherEmailVerification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Label label3;
    }
}