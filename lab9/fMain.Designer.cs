namespace lb9
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbx1min = new System.Windows.Forms.TextBox();
            this.tbx2min = new System.Windows.Forms.TextBox();
            this.tbx1max = new System.Windows.Forms.TextBox();
            this.tbx2max = new System.Windows.Forms.TextBox();
            this.tbdx1 = new System.Windows.Forms.TextBox();
            this.tbdx2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(22, 127);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(543, 311);
            this.gv.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "X1min";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "X2min";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(202, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "X1max";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(202, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "X2max";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(396, 41);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(26, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "dX1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(396, 104);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(26, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "dX2";
            // 
            // tbx1min
            // 
            this.tbx1min.Location = new System.Drawing.Point(70, 38);
            this.tbx1min.Name = "tbx1min";
            this.tbx1min.Size = new System.Drawing.Size(100, 20);
            this.tbx1min.TabIndex = 7;
            // 
            // tbx2min
            // 
            this.tbx2min.Location = new System.Drawing.Point(70, 97);
            this.tbx2min.Name = "tbx2min";
            this.tbx2min.Size = new System.Drawing.Size(100, 20);
            this.tbx2min.TabIndex = 8;
            // 
            // tbx1max
            // 
            this.tbx1max.Location = new System.Drawing.Point(253, 38);
            this.tbx1max.Name = "tbx1max";
            this.tbx1max.Size = new System.Drawing.Size(100, 20);
            this.tbx1max.TabIndex = 9;
            // 
            // tbx2max
            // 
            this.tbx2max.Location = new System.Drawing.Point(253, 97);
            this.tbx2max.Name = "tbx2max";
            this.tbx2max.Size = new System.Drawing.Size(100, 20);
            this.tbx2max.TabIndex = 10;
            // 
            // tbdx1
            // 
            this.tbdx1.Location = new System.Drawing.Point(465, 38);
            this.tbdx1.Name = "tbdx1";
            this.tbdx1.Size = new System.Drawing.Size(100, 20);
            this.tbdx1.TabIndex = 11;
            // 
            // tbdx2
            // 
            this.tbdx2.Location = new System.Drawing.Point(465, 101);
            this.tbdx2.Name = "tbdx2";
            this.tbdx2.Size = new System.Drawing.Size(100, 20);
            this.tbdx2.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(571, 127);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Розрахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(571, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbdx2);
            this.Controls.Add(this.tbdx1);
            this.Controls.Add(this.tbx2max);
            this.Controls.Add(this.tbx1max);
            this.Controls.Add(this.tbx2min);
            this.Controls.Add(this.tbx1min);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gv);
            this.Name = "fMain";
            this.Text = "Лабараторна 9";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox tbx1min;
        private System.Windows.Forms.TextBox tbx2min;
        private System.Windows.Forms.TextBox tbx1max;
        private System.Windows.Forms.TextBox tbx2max;
        private System.Windows.Forms.TextBox tbdx1;
        private System.Windows.Forms.TextBox tbdx2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

