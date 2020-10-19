namespace BonelessPizzasTest
{
    partial class Form3
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
            this.NewOrder = new System.Windows.Forms.Button();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.NewOrder.ForeColor = System.Drawing.Color.White;
            this.NewOrder.Location = new System.Drawing.Point(37, 167);
            this.NewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(128, 33);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "Place New Order";
            this.NewOrder.UseVisualStyleBackColor = false;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.OrderHistory.ForeColor = System.Drawing.Color.White;
            this.OrderHistory.Location = new System.Drawing.Point(344, 167);
            this.OrderHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(128, 33);
            this.OrderHistory.TabIndex = 1;
            this.OrderHistory.Text = "Order History";
            this.OrderHistory.UseVisualStyleBackColor = false;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BonelessPizzasTest.Properties.Resources.WelcomeBack2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 418);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.NewOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Back!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button OrderHistory;
    }
}