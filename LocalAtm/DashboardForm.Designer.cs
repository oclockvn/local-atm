namespace LocalAtm
{
    partial class DashboardForm
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
            btnViewBalance = new Button();
            btnWidthdraw = new Button();
            btnViewTransactions = new Button();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // btnViewBalance
            // 
            btnViewBalance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViewBalance.Location = new Point(21, 156);
            btnViewBalance.Name = "btnViewBalance";
            btnViewBalance.Size = new Size(448, 34);
            btnViewBalance.TabIndex = 0;
            btnViewBalance.Text = "View Balance";
            btnViewBalance.UseVisualStyleBackColor = true;
            btnViewBalance.Click += btnViewBalance_Click;
            // 
            // btnWidthdraw
            // 
            btnWidthdraw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWidthdraw.Location = new Point(21, 208);
            btnWidthdraw.Name = "btnWidthdraw";
            btnWidthdraw.Size = new Size(448, 34);
            btnWidthdraw.TabIndex = 1;
            btnWidthdraw.Text = "Widthdraw";
            btnWidthdraw.UseVisualStyleBackColor = true;
            btnWidthdraw.Click += btnWidthdraw_Click;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViewTransactions.Location = new Point(21, 260);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(448, 34);
            btnViewTransactions.TabIndex = 2;
            btnViewTransactions.Text = "View Last Transactions";
            btnViewTransactions.UseVisualStyleBackColor = true;
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(33, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Hi,";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(lblUsername);
            Controls.Add(btnViewTransactions);
            Controls.Add(btnWidthdraw);
            Controls.Add(btnViewBalance);
            Name = "DashboardForm";
            Text = "Dashboard | ATM version 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewBalance;
        private Button btnWidthdraw;
        private Button btnViewTransactions;
        private Label lblUsername;
    }
}