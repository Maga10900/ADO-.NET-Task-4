namespace WinFormsApp6
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
            listBox1 = new ListBox();
            MakeTXT = new Label();
            StNumberTXT = new Label();
            YearTXT = new Label();
            ModelTXT = new Label();
            MakeTxtBox = new TextBox();
            ModelTxtBox = new TextBox();
            YearTxtBox = new TextBox();
            SNumberTxtBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 284);
            listBox1.TabIndex = 0;
            // 
            // MakeTXT
            // 
            MakeTXT.AutoSize = true;
            MakeTXT.Font = new Font("Segoe UI", 12F);
            MakeTXT.Location = new Point(437, 30);
            MakeTXT.Name = "MakeTXT";
            MakeTXT.Size = new Size(60, 28);
            MakeTXT.TabIndex = 1;
            MakeTXT.Text = "Make";
            // 
            // StNumberTXT
            // 
            StNumberTXT.AutoSize = true;
            StNumberTXT.Font = new Font("Segoe UI", 12F);
            StNumberTXT.Location = new Point(437, 183);
            StNumberTXT.Name = "StNumberTXT";
            StNumberTXT.Size = new Size(110, 28);
            StNumberTXT.TabIndex = 2;
            StNumberTXT.Text = "St. Number";
            // 
            // YearTXT
            // 
            YearTXT.AutoSize = true;
            YearTXT.Font = new Font("Segoe UI", 12F);
            YearTXT.Location = new Point(437, 130);
            YearTXT.Name = "YearTXT";
            YearTXT.Size = new Size(48, 28);
            YearTXT.TabIndex = 3;
            YearTXT.Text = "Year";
            // 
            // ModelTXT
            // 
            ModelTXT.AutoSize = true;
            ModelTXT.Font = new Font("Segoe UI", 12F);
            ModelTXT.Location = new Point(437, 76);
            ModelTXT.Name = "ModelTXT";
            ModelTXT.Size = new Size(69, 28);
            ModelTXT.TabIndex = 4;
            ModelTXT.Text = "Model";
            // 
            // MakeTxtBox
            // 
            MakeTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MakeTxtBox.Location = new Point(575, 24);
            MakeTxtBox.Name = "MakeTxtBox";
            MakeTxtBox.Size = new Size(261, 34);
            MakeTxtBox.TabIndex = 5;
            // 
            // ModelTxtBox
            // 
            ModelTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModelTxtBox.Location = new Point(575, 70);
            ModelTxtBox.Name = "ModelTxtBox";
            ModelTxtBox.Size = new Size(261, 34);
            ModelTxtBox.TabIndex = 6;
            // 
            // YearTxtBox
            // 
            YearTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YearTxtBox.Location = new Point(575, 127);
            YearTxtBox.Name = "YearTxtBox";
            YearTxtBox.Size = new Size(261, 34);
            YearTxtBox.TabIndex = 7;
            // 
            // SNumberTxtBox
            // 
            SNumberTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SNumberTxtBox.Location = new Point(575, 183);
            SNumberTxtBox.Name = "SNumberTxtBox";
            SNumberTxtBox.Size = new Size(261, 34);
            SNumberTxtBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(488, 265);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(724, 265);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 10;
            button2.Text = "Upgrade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(606, 265);
            button3.Name = "button3";
            button3.Size = new Size(112, 41);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 327);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SNumberTxtBox);
            Controls.Add(YearTxtBox);
            Controls.Add(ModelTxtBox);
            Controls.Add(MakeTxtBox);
            Controls.Add(ModelTXT);
            Controls.Add(YearTXT);
            Controls.Add(StNumberTXT);
            Controls.Add(MakeTXT);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label MakeTXT;
        private Label StNumberTXT;
        private Label YearTXT;
        private Label ModelTXT;
        private TextBox MakeTxtBox;
        private TextBox ModelTxtBox;
        private TextBox YearTxtBox;
        private TextBox SNumberTxtBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
