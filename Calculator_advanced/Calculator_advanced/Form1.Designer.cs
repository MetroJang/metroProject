namespace Calculator_advanced
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.cal_add = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.cal_sub = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.cal_mul = new System.Windows.Forms.Button();
            this.cal_dot = new System.Windows.Forms.Button();
            this.cal_equal = new System.Windows.Forms.Button();
            this.cal_div = new System.Windows.Forms.Button();
            this.cal_back = new System.Windows.Forms.Button();
            this.cal_sigma = new System.Windows.Forms.Button();
            this.cal_result = new System.Windows.Forms.TextBox();
            this.cal_alert = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "5585543 장진우";
            // 
            // num1
            // 
            this.num1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num1.Location = new System.Drawing.Point(23, 107);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 23);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(104, 107);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 23);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(185, 107);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 23);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // cal_add
            // 
            this.cal_add.Location = new System.Drawing.Point(266, 107);
            this.cal_add.Name = "cal_add";
            this.cal_add.Size = new System.Drawing.Size(75, 23);
            this.cal_add.TabIndex = 4;
            this.cal_add.Text = "+";
            this.cal_add.UseVisualStyleBackColor = true;
            this.cal_add.Click += new System.EventHandler(this.cal_add_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(23, 136);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 23);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(23, 165);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 23);
            this.num7.TabIndex = 6;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(23, 194);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 23);
            this.num0.TabIndex = 7;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(104, 136);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 23);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(185, 136);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 23);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // cal_sub
            // 
            this.cal_sub.Location = new System.Drawing.Point(266, 136);
            this.cal_sub.Name = "cal_sub";
            this.cal_sub.Size = new System.Drawing.Size(75, 23);
            this.cal_sub.TabIndex = 10;
            this.cal_sub.Text = "-";
            this.cal_sub.UseVisualStyleBackColor = true;
            this.cal_sub.Click += new System.EventHandler(this.cal_sub_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(104, 165);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 23);
            this.num8.TabIndex = 11;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(185, 165);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 23);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // cal_mul
            // 
            this.cal_mul.Location = new System.Drawing.Point(266, 165);
            this.cal_mul.Name = "cal_mul";
            this.cal_mul.Size = new System.Drawing.Size(75, 23);
            this.cal_mul.TabIndex = 13;
            this.cal_mul.Text = "*";
            this.cal_mul.UseVisualStyleBackColor = true;
            this.cal_mul.Click += new System.EventHandler(this.cal_mul_Click);
            // 
            // cal_dot
            // 
            this.cal_dot.Location = new System.Drawing.Point(104, 194);
            this.cal_dot.Name = "cal_dot";
            this.cal_dot.Size = new System.Drawing.Size(75, 23);
            this.cal_dot.TabIndex = 14;
            this.cal_dot.Text = ".";
            this.cal_dot.UseVisualStyleBackColor = true;
            this.cal_dot.Click += new System.EventHandler(this.cal_dot_Click);
            // 
            // cal_equal
            // 
            this.cal_equal.Location = new System.Drawing.Point(185, 194);
            this.cal_equal.Name = "cal_equal";
            this.cal_equal.Size = new System.Drawing.Size(75, 23);
            this.cal_equal.TabIndex = 15;
            this.cal_equal.Text = "=";
            this.cal_equal.UseVisualStyleBackColor = true;
            this.cal_equal.Click += new System.EventHandler(this.cal_equal_Click);
            // 
            // cal_div
            // 
            this.cal_div.Location = new System.Drawing.Point(266, 194);
            this.cal_div.Name = "cal_div";
            this.cal_div.Size = new System.Drawing.Size(75, 23);
            this.cal_div.TabIndex = 16;
            this.cal_div.Text = "/";
            this.cal_div.UseVisualStyleBackColor = true;
            this.cal_div.Click += new System.EventHandler(this.cal_div_Click);
            // 
            // cal_back
            // 
            this.cal_back.Location = new System.Drawing.Point(379, 107);
            this.cal_back.Name = "cal_back";
            this.cal_back.Size = new System.Drawing.Size(75, 23);
            this.cal_back.TabIndex = 17;
            this.cal_back.Text = "Back";
            this.cal_back.UseVisualStyleBackColor = true;
            this.cal_back.Click += new System.EventHandler(this.cal_back_Click);
            // 
            // cal_sigma
            // 
            this.cal_sigma.Location = new System.Drawing.Point(379, 165);
            this.cal_sigma.Name = "cal_sigma";
            this.cal_sigma.Size = new System.Drawing.Size(75, 23);
            this.cal_sigma.TabIndex = 19;
            this.cal_sigma.Text = "Sigma";
            this.cal_sigma.UseVisualStyleBackColor = true;
            this.cal_sigma.Click += new System.EventHandler(this.cal_sigma_Click);
            // 
            // cal_result
            // 
            this.cal_result.Location = new System.Drawing.Point(23, 45);
            this.cal_result.Name = "cal_result";
            this.cal_result.Size = new System.Drawing.Size(431, 21);
            this.cal_result.TabIndex = 20;
            // 
            // cal_alert
            // 
            this.cal_alert.AutoSize = true;
            this.cal_alert.Location = new System.Drawing.Point(44, 78);
            this.cal_alert.Name = "cal_alert";
            this.cal_alert.Size = new System.Drawing.Size(0, 12);
            this.cal_alert.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cal_remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cal_alert);
            this.Controls.Add(this.cal_result);
            this.Controls.Add(this.cal_sigma);
            this.Controls.Add(this.cal_back);
            this.Controls.Add(this.cal_div);
            this.Controls.Add(this.cal_equal);
            this.Controls.Add(this.cal_dot);
            this.Controls.Add(this.cal_mul);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.cal_sub);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.cal_add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "cal_remove";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button cal_add;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button cal_sub;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button cal_mul;
        private System.Windows.Forms.Button cal_dot;
        private System.Windows.Forms.Button cal_equal;
        private System.Windows.Forms.Button cal_div;
        private System.Windows.Forms.Button cal_back;
        private System.Windows.Forms.Button cal_sigma;
        private System.Windows.Forms.TextBox cal_result;
        private System.Windows.Forms.Label cal_alert;
        private System.Windows.Forms.Button button1;
    }
}

