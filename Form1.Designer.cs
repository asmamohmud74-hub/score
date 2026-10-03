namespace socre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTestScore1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTestScore2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTestScore3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAverage = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter three test score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Score1";
            // 
            // textTestScore1
            // 
            this.textTestScore1.Location = new System.Drawing.Point(250, 95);
            this.textTestScore1.Name = "textTestScore1";
            this.textTestScore1.Size = new System.Drawing.Size(226, 26);
            this.textTestScore1.TabIndex = 2;
            this.textTestScore1.TextChanged += new System.EventHandler(this.textTestScore1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Test Score2";
            // 
            // textTestScore2
            // 
            this.textTestScore2.Location = new System.Drawing.Point(250, 164);
            this.textTestScore2.Name = "textTestScore2";
            this.textTestScore2.Size = new System.Drawing.Size(258, 26);
            this.textTestScore2.TabIndex = 4;
            this.textTestScore2.TextChanged += new System.EventHandler(this.textTestScore2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Test Score3";
            // 
            // textTestScore3
            // 
            this.textTestScore3.Location = new System.Drawing.Point(237, 236);
            this.textTestScore3.Name = "textTestScore3";
            this.textTestScore3.Size = new System.Drawing.Size(257, 26);
            this.textTestScore3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Average";
            // 
            // textAverage
            // 
            this.textAverage.Location = new System.Drawing.Point(251, 306);
            this.textAverage.Name = "textAverage";
            this.textAverage.Size = new System.Drawing.Size(257, 26);
            this.textAverage.TabIndex = 8;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(306, 377);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(105, 55);
            this.txtAverage.TabIndex = 9;
            this.txtAverage.Text = "calculateAverage";
            this.txtAverage.UseVisualStyleBackColor = true;
            this.txtAverage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(493, 353);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(75, 57);
            this.txtclear.TabIndex = 10;
            this.txtclear.Text = "clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtclear);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.textAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTestScore3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTestScore2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTestScore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTestScore1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTestScore2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTestScore3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAverage;
        private System.Windows.Forms.Button txtAverage;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.Button button3;
    }
}

