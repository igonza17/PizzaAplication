namespace BonelessPizzasTest
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
            this.HomeRegister = new System.Windows.Forms.Button();
            this.HomeLogin = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeRegister
            // 
            this.HomeRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.HomeRegister.ForeColor = System.Drawing.Color.White;
            this.HomeRegister.Location = new System.Drawing.Point(280, 270);
            this.HomeRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeRegister.Name = "HomeRegister";
            this.HomeRegister.Size = new System.Drawing.Size(117, 41);
            this.HomeRegister.TabIndex = 0;
            this.HomeRegister.Text = "Register";
            this.HomeRegister.UseVisualStyleBackColor = false;
            this.HomeRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeLogin
            // 
            this.HomeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.HomeLogin.ForeColor = System.Drawing.Color.White;
            this.HomeLogin.Location = new System.Drawing.Point(117, 270);
            this.HomeLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeLogin.Name = "HomeLogin";
            this.HomeLogin.Size = new System.Drawing.Size(117, 41);
            this.HomeLogin.TabIndex = 1;
            this.HomeLogin.Text = "Log In";
            this.HomeLogin.UseVisualStyleBackColor = false;
            this.HomeLogin.Click += new System.EventHandler(this.HomeLogin_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.PhoneNumber.Location = new System.Drawing.Point(117, 193);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(282, 45);
            this.PhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ErrorMessage.ForeColor = System.Drawing.Color.White;
            this.ErrorMessage.Location = new System.Drawing.Point(115, 162);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.ErrorMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::BonelessPizzasTest.Properties.Resources.BonelessPizza2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 404);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.HomeLogin);
            this.Controls.Add(this.HomeRegister);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boneless Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeRegister;
        private System.Windows.Forms.Button HomeLogin;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

