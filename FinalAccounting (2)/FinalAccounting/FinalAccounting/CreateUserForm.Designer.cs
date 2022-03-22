namespace FinalAccounting
{
    partial class CreateUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.backMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(120, 79);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(139, 20);
            this.firstNameBox.TabIndex = 4;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(120, 125);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(139, 20);
            this.lastNameBox.TabIndex = 5;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(120, 161);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(139, 20);
            this.userNameBox.TabIndex = 6;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(120, 200);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(139, 20);
            this.passBox.TabIndex = 7;
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Location = new System.Drawing.Point(120, 246);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateUserBtn.TabIndex = 8;
            this.CreateUserBtn.Text = "Create";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // backMainBtn
            // 
            this.backMainBtn.Location = new System.Drawing.Point(120, 298);
            this.backMainBtn.Name = "backMainBtn";
            this.backMainBtn.Size = new System.Drawing.Size(75, 39);
            this.backMainBtn.TabIndex = 9;
            this.backMainBtn.Text = "Back To Login";
            this.backMainBtn.UseVisualStyleBackColor = true;
            this.backMainBtn.Click += new System.EventHandler(this.backMainBtn_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 402);
            this.Controls.Add(this.backMainBtn);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.Button backMainBtn;
    }
}