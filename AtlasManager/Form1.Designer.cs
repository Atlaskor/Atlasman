namespace AtlasManager
{
    partial class AtlasManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtlasManager));
            this.SubmitButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.ListBox();
            this.PassBox = new System.Windows.Forms.ListBox();
            this.ServiceBox = new System.Windows.Forms.ListBox();
            this.ServicesBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CopyUserBox = new System.Windows.Forms.TextBox();
            this.CopyPassBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PassHide = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.Location = new System.Drawing.Point(111, 171);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(98, 113);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 23);
            this.UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(98, 142);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordBox.TabIndex = 2;
            // 
            // UserBox
            // 
            this.UserBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserBox.FormattingEnabled = true;
            this.UserBox.ItemHeight = 15;
            this.UserBox.Location = new System.Drawing.Point(314, 42);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(230, 259);
            this.UserBox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassBox.FormattingEnabled = true;
            this.PassBox.ItemHeight = 15;
            this.PassBox.Location = new System.Drawing.Point(550, 42);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(205, 259);
            this.PassBox.TabIndex = 4;
            // 
            // ServiceBox
            // 
            this.ServiceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServiceBox.FormattingEnabled = true;
            this.ServiceBox.ItemHeight = 15;
            this.ServiceBox.Location = new System.Drawing.Point(204, 42);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(104, 259);
            this.ServiceBox.TabIndex = 5;
            // 
            // ServicesBox
            // 
            this.ServicesBox.Location = new System.Drawing.Point(98, 84);
            this.ServicesBox.Name = "ServicesBox";
            this.ServicesBox.Size = new System.Drawing.Size(100, 23);
            this.ServicesBox.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(111, 200);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(111, 229);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CopyUserBox
            // 
            this.CopyUserBox.Location = new System.Drawing.Point(314, 13);
            this.CopyUserBox.Name = "CopyUserBox";
            this.CopyUserBox.Size = new System.Drawing.Size(230, 23);
            this.CopyUserBox.TabIndex = 9;
            // 
            // CopyPassBox
            // 
            this.CopyPassBox.Location = new System.Drawing.Point(550, 14);
            this.CopyPassBox.Name = "CopyPassBox";
            this.CopyPassBox.Size = new System.Drawing.Size(205, 23);
            this.CopyPassBox.TabIndex = 10;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(111, 258);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 11;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PassHide
            // 
            this.PassHide.AutoSize = true;
            this.PassHide.Location = new System.Drawing.Point(204, 18);
            this.PassHide.Name = "PassHide";
            this.PassHide.Size = new System.Drawing.Size(104, 19);
            this.PassHide.TabIndex = 12;
            this.PassHide.Text = "Hide Password";
            this.PassHide.UseVisualStyleBackColor = true;
            this.PassHide.CheckedChanged += new System.EventHandler(this.PassHide_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // AtlasManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassHide);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.CopyPassBox);
            this.Controls.Add(this.CopyUserBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ServicesBox);
            this.Controls.Add(this.ServiceBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.SubmitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtlasManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "AtlasManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitButton;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private ListBox UserBox;
        private ListBox PassBox;
        private ListBox ServiceBox;
        private TextBox ServicesBox;
        private Button SaveButton;
        private Button LoadButton;
        private TextBox CopyUserBox;
        private TextBox CopyPassBox;
        private Button CopyButton;
        private CheckBox PassHide;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}