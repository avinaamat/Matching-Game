namespace Matching_Game
{
    partial class UserProfile
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
            this.Submit = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salutation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.first_name_msg = new System.Windows.Forms.Label();
            this.last_name_msg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.email_msg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(432, 282);
            this.Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(135, 49);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(176, 137);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(195, 32);
            this.FirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Profile";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salutation:";
            // 
            // Salutation
            // 
            this.Salutation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Salutation.BackColor = System.Drawing.SystemColors.Window;
            this.Salutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salutation.FormattingEnabled = true;
            this.Salutation.Items.AddRange(new object[] {
            " ",
            "Mrs.",
            "Mr.",
            "Mx.",
            "Dr.",
            "Profesor"});
            this.Salutation.Location = new System.Drawing.Point(176, 97);
            this.Salutation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Salutation.Name = "Salutation";
            this.Salutation.Size = new System.Drawing.Size(195, 28);
            this.Salutation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name *";
            // 
            // first_name_msg
            // 
            this.first_name_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.first_name_msg.AutoSize = true;
            this.first_name_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_msg.Location = new System.Drawing.Point(395, 148);
            this.first_name_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_name_msg.Name = "first_name_msg";
            this.first_name_msg.Size = new System.Drawing.Size(59, 20);
            this.first_name_msg.TabIndex = 6;
            this.first_name_msg.Text = "          ";
            // 
            // last_name_msg
            // 
            this.last_name_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.last_name_msg.AutoSize = true;
            this.last_name_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_msg.Location = new System.Drawing.Point(395, 191);
            this.last_name_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last_name_msg.Name = "last_name_msg";
            this.last_name_msg.Size = new System.Drawing.Size(59, 20);
            this.last_name_msg.TabIndex = 9;
            this.last_name_msg.Text = "          ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name *";
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(176, 180);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(195, 32);
            this.LastName.TabIndex = 3;
            // 
            // email_msg
            // 
            this.email_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_msg.AutoSize = true;
            this.email_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_msg.Location = new System.Drawing.Point(395, 241);
            this.email_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_msg.Name = "email_msg";
            this.email_msg.Size = new System.Drawing.Size(59, 20);
            this.email_msg.TabIndex = 12;
            this.email_msg.Text = "          ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email *";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(176, 231);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 32);
            this.Email.TabIndex = 4;
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(61, 282);
            this.Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(135, 49);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.email_msg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.last_name_msg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.first_name_msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salutation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Submit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Salutation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label first_name_msg;
        private System.Windows.Forms.Label last_name_msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label email_msg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Reset;
    }
}

