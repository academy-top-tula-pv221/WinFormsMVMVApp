namespace WinFormsMVMVApp
{
    partial class Form1
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
            listUsers = new ListBox();
            labelSelectedUser = new Label();
            textNewName = new TextBox();
            numNewAge = new NumericUpDown();
            btnNewUser = new Button();
            btnDelUser = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numNewAge).BeginInit();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 37;
            listUsers.Location = new Point(12, 12);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(274, 300);
            listUsers.TabIndex = 0;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            listUsers.SelectedValueChanged += listUsers_SelectedValueChanged;
            // 
            // labelSelectedUser
            // 
            labelSelectedUser.AutoSize = true;
            labelSelectedUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedUser.Location = new Point(698, 404);
            labelSelectedUser.Name = "labelSelectedUser";
            labelSelectedUser.Size = new Size(90, 37);
            labelSelectedUser.TabIndex = 1;
            labelSelectedUser.Text = "label1";
            // 
            // textNewName
            // 
            textNewName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textNewName.Location = new Point(356, 12);
            textNewName.Name = "textNewName";
            textNewName.Size = new Size(266, 43);
            textNewName.TabIndex = 2;
            // 
            // numNewAge
            // 
            numNewAge.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            numNewAge.Location = new Point(356, 83);
            numNewAge.Name = "numNewAge";
            numNewAge.Size = new Size(266, 43);
            numNewAge.TabIndex = 3;
            // 
            // btnNewUser
            // 
            btnNewUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewUser.Location = new Point(356, 157);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(266, 60);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "Add New User";
            btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnDelUser
            // 
            btnDelUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelUser.Location = new Point(356, 244);
            btnDelUser.Name = "btnDelUser";
            btnDelUser.Size = new Size(266, 53);
            btnDelUser.TabIndex = 5;
            btnDelUser.Text = "Delete User";
            btnDelUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 404);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnDelUser);
            Controls.Add(btnNewUser);
            Controls.Add(numNewAge);
            Controls.Add(textNewName);
            Controls.Add(labelSelectedUser);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNewAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private Label labelSelectedUser;
        private TextBox textNewName;
        private NumericUpDown numNewAge;
        private Button btnNewUser;
        private Button btnDelUser;
        private Button button1;
    }
}