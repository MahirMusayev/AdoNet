namespace WinFormsApp2
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
            dataGridView1 = new DataGridView();
            surnameinput = new TextBox();
            nameinput = new TextBox();
            usernameinput = new TextBox();
            passwordinput = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            deletebtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(795, 12);
            button1.Name = "button1";
            button1.Size = new Size(98, 46);
            button1.TabIndex = 0;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(928, 335);
            dataGridView1.TabIndex = 2;
            // 
            // surnameinput
            // 
            surnameinput.Location = new Point(22, 55);
            surnameinput.Name = "surnameinput";
            surnameinput.Size = new Size(151, 27);
            surnameinput.TabIndex = 4;
            // 
            // nameinput
            // 
            nameinput.Location = new Point(22, 14);
            nameinput.Name = "nameinput";
            nameinput.Size = new Size(151, 27);
            nameinput.TabIndex = 5;
            // 
            // usernameinput
            // 
            usernameinput.Location = new Point(22, 98);
            usernameinput.Name = "usernameinput";
            usernameinput.Size = new Size(151, 27);
            usernameinput.TabIndex = 6;
            usernameinput.TextChanged += textBox3_TextChanged;
            // 
            // passwordinput
            // 
            passwordinput.Location = new Point(22, 140);
            passwordinput.Name = "passwordinput";
            passwordinput.Size = new Size(151, 27);
            passwordinput.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(256, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "qadin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(199, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 24);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "kisi";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(668, 15);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(98, 43);
            deletebtn.TabIndex = 10;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(703, 84);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 529);
            Controls.Add(button2);
            Controls.Add(deletebtn);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(passwordinput);
            Controls.Add(usernameinput);
            Controls.Add(nameinput);
            Controls.Add(surnameinput);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox surnameinput;
        private TextBox nameinput;
        private TextBox usernameinput;
        private TextBox passwordinput;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button deletebtn;
        private Button button2;
    }
}
