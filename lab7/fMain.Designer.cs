namespace lab7
{
    partial class fMain
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            tbY = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 208);
            button1.Name = "button1";
            button1.Size = new Size(113, 56);
            button1.TabIndex = 0;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(249, 208);
            button2.Name = "button2";
            button2.Size = new Size(116, 56);
            button2.TabIndex = 1;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(427, 208);
            button3.Name = "button3";
            button3.Size = new Size(144, 56);
            button3.TabIndex = 2;
            button3.Text = "Вихід";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Змінна X1";
            label1.UseWaitCursor = true;
            label1.TextChanged += label1_TextChanged;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(54, 84);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Змінна X2";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(54, 147);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Результат Y";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // tbX1
            // 
            tbX1.Location = new Point(399, 33);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(172, 23);
            tbX1.TabIndex = 6;
            tbX1.UseWaitCursor = true;
            tbX1.TextChanged += textBox1_TextChanged;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(399, 84);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(172, 23);
            tbX2.TabIndex = 7;
            tbX2.UseWaitCursor = true;
            // 
            // tbY
            // 
            tbY.Location = new Point(399, 147);
            tbY.Name = "tbY";
            tbY.Size = new Size(172, 23);
            tbY.TabIndex = 8;
            tbY.UseWaitCursor = true;
            // 
            // fMain
            // 
            AccessibleName = "123";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(11, 1);
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(589, 279);
            Controls.Add(tbY);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "fMain";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "лабараторна 7";
            UseWaitCursor = true;
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        internal Label label1;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY;
    }
}
