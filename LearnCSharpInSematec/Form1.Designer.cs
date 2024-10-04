namespace LearnCSharpInSematec
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
            button1 = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lastNameTextBox = new TextBox();
            label5 = new Label();
            phoneNumberTextBox = new TextBox();
            label6 = new Label();
            nationalCodeTextBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 99);
            button1.Name = "button1";
            button1.Size = new Size(249, 39);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(72, 28);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(182, 23);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(71, 57);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(183, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(412, 6);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(182, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 9);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "FirstName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 45);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "LastName: ";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(412, 42);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(182, 23);
            lastNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 86);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "PhoneNumber: ";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(441, 83);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(153, 23);
            phoneNumberTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 123);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "NationalCode:";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(441, 115);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(153, 23);
            nationalCodeTextBox.TabIndex = 11;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(346, 144);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(249, 39);
            registerButton.TabIndex = 13;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 194);
            Controls.Add(registerButton);
            Controls.Add(label6);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(label5);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label4);
            Controls.Add(lastNameTextBox);
            Controls.Add(label3);
            Controls.Add(firstNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private TextBox firstNameTextBox;
        private Label label3;
        private Label label4;
        private TextBox lastNameTextBox;
        private Label label5;
        private TextBox phoneNumberTextBox;
        private Label label6;
        private TextBox nationalCodeTextBox;
        private Button registerButton;
    }
}
