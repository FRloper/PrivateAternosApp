namespace Aternos_Application
{
    partial class Form1
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
            this.perms = new System.Windows.Forms.CheckedListBox();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r6 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.duser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.auser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // perms
            // 
            this.perms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.perms.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perms.ForeColor = System.Drawing.Color.White;
            this.perms.FormattingEnabled = true;
            this.perms.Items.AddRange(new object[] {
            "Start",
            "Stop/Restart [Respected Ranks]",
            "Logs [Respected Ranks]",
            "Options [Admin+]",
            "Files [Head Admin+]",
            "Players [Head Admin+]",
            "Worlds [Co-Owner]"});
            this.perms.Location = new System.Drawing.Point(10, 222);
            this.perms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.perms.Name = "perms";
            this.perms.Size = new System.Drawing.Size(226, 116);
            this.perms.TabIndex = 0;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(10, 172);
            this.r1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(63, 19);
            this.r1.TabIndex = 1;
            this.r1.TabStop = true;
            this.r1.Text = "Member";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you?*";
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(96, 197);
            this.r4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(54, 19);
            this.r4.TabIndex = 3;
            this.r4.TabStop = true;
            this.r4.Text = "Admin";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(154, 197);
            this.r5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(80, 19);
            this.r5.TabIndex = 4;
            this.r5.TabStop = true;
            this.r5.Text = "Head Admin";
            this.r5.UseVisualStyleBackColor = true;
            // 
            // r6
            // 
            this.r6.AutoSize = true;
            this.r6.Location = new System.Drawing.Point(154, 172);
            this.r6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r6.Name = "r6";
            this.r6.Size = new System.Drawing.Size(70, 19);
            this.r6.TabIndex = 5;
            this.r6.TabStop = true;
            this.r6.Text = "Co-Owner";
            this.r6.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(11, 197);
            this.r2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(81, 19);
            this.r2.TabIndex = 6;
            this.r2.TabStop = true;
            this.r2.Text = "Higher Rank";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(82, 172);
            this.r3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(64, 19);
            this.r3.TabIndex = 7;
            this.r3.TabStop = true;
            this.r3.Text = "GWinner";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // duser
            // 
            this.duser.Location = new System.Drawing.Point(10, 80);
            this.duser.Name = "duser";
            this.duser.Size = new System.Drawing.Size(160, 21);
            this.duser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Discord Username [Main Contact]*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aternos Username [Access Key]*";
            // 
            // auser
            // 
            this.auser.Location = new System.Drawing.Point(10, 38);
            this.auser.Name = "auser";
            this.auser.Size = new System.Drawing.Size(149, 21);
            this.auser.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(131)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(161, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fill Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fill Info [Optional]";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(131)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(85)))), ((int)(((byte)(171)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(158, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Send Access";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(105)))), ((int)(((byte)(251)))));
            this.role.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Member",
            "Respected Role [HR]",
            "Admin",
            "Head Admin",
            "Co-Owner"});
            this.role.Location = new System.Drawing.Point(10, 139);
            this.role.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(226, 84);
            this.role.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(245, 384);
            this.Controls.Add(this.role);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duser);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r6);
            this.Controls.Add(this.r5);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.perms);
            this.Font = new System.Drawing.Font("Impact", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aternos Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox perms;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r6;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.TextBox duser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox auser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox role;
    }
}

