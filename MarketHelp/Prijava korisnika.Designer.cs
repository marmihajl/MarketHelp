namespace MarketHelp
{
    partial class Prijava_korisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(124, 54);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(141, 20);
            this.UsernameTB.TabIndex = 2;
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(124, 92);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(141, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(138, 134);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(114, 46);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log in!";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // Prijava_korisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 254);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prijava_korisnika";
            this.Text = "Prijava_korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LogInButton;
    }
}