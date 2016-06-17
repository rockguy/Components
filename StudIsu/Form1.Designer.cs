namespace StudIsu
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
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.StudentNameBox = new System.Windows.Forms.ComboBox();
            this.StudentFNameBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NFNameBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NNameBox = new System.Windows.Forms.TextBox();
            this.NMarkBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NGroup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(121, 21);
            this.GroupBox.TabIndex = 0;
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.FormattingEnabled = true;
            this.StudentNameBox.Location = new System.Drawing.Point(12, 123);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(121, 21);
            this.StudentNameBox.TabIndex = 1;
            // 
            // StudentFNameBox
            // 
            this.StudentFNameBox.FormattingEnabled = true;
            this.StudentFNameBox.Location = new System.Drawing.Point(12, 65);
            this.StudentFNameBox.Name = "StudentFNameBox";
            this.StudentFNameBox.Size = new System.Drawing.Size(121, 21);
            this.StudentFNameBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(250, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 134);
            this.listBox1.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(871, 184);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NFNameBox
            // 
            this.NFNameBox.Location = new System.Drawing.Point(591, 82);
            this.NFNameBox.Name = "NFNameBox";
            this.NFNameBox.Size = new System.Drawing.Size(251, 20);
            this.NFNameBox.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(591, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 20);
            this.textBox3.TabIndex = 4;
            // 
            // NNameBox
            // 
            this.NNameBox.Location = new System.Drawing.Point(591, 126);
            this.NNameBox.Name = "NNameBox";
            this.NNameBox.Size = new System.Drawing.Size(251, 20);
            this.NNameBox.TabIndex = 4;
            // 
            // NMarkBox
            // 
            this.NMarkBox.Location = new System.Drawing.Point(591, 170);
            this.NMarkBox.Name = "NMarkBox";
            this.NMarkBox.Size = new System.Drawing.Size(251, 20);
            this.NMarkBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mark";
            // 
            // NGroup
            // 
            this.NGroup.FormattingEnabled = true;
            this.NGroup.Location = new System.Drawing.Point(591, 38);
            this.NGroup.Name = "NGroup";
            this.NGroup.Size = new System.Drawing.Size(251, 21);
            this.NGroup.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 219);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NMarkBox);
            this.Controls.Add(this.NNameBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.NFNameBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StudentFNameBox);
            this.Controls.Add(this.StudentNameBox);
            this.Controls.Add(this.NGroup);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.ComboBox StudentNameBox;
        private System.Windows.Forms.ComboBox StudentFNameBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NFNameBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox NNameBox;
        private System.Windows.Forms.TextBox NMarkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NGroup;
    }
}

