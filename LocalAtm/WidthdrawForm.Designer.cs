namespace LocalAtm
{
    partial class WidthdrawForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(638, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "Error";
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccept.Location = new Point(488, 121);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(162, 34);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(370, 121);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // WidthdrawForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 173);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "WidthdrawForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Widthdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button btnAccept;
        private Button btnCancel;
    }
}