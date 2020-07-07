namespace hw1_introUself
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSqayHi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNaneC = new System.Windows.Forms.TextBox();
            this.tboxNameEngilsh = new System.Windows.Forms.TextBox();
            this.tboxGender = new System.Windows.Forms.TextBox();
            this.tboxStarS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(438, 381);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(152, 48);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello !";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSqayHi
            // 
            this.btnSqayHi.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSqayHi.Location = new System.Drawing.Point(621, 381);
            this.btnSqayHi.Name = "btnSqayHi";
            this.btnSqayHi.Size = new System.Drawing.Size(152, 48);
            this.btnSqayHi.TabIndex = 1;
            this.btnSqayHi.Text = "Say Hi !";
            this.btnSqayHi.UseVisualStyleBackColor = true;
            this.btnSqayHi.Click += new System.EventHandler(this.btnSqayHi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "English Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxNaneC
            // 
            this.tboxNaneC.Location = new System.Drawing.Point(226, 67);
            this.tboxNaneC.Name = "tboxNaneC";
            this.tboxNaneC.Size = new System.Drawing.Size(157, 22);
            this.tboxNaneC.TabIndex = 6;
            // 
            // tboxNameEngilsh
            // 
            this.tboxNameEngilsh.Location = new System.Drawing.Point(226, 138);
            this.tboxNameEngilsh.Name = "tboxNameEngilsh";
            this.tboxNameEngilsh.Size = new System.Drawing.Size(157, 22);
            this.tboxNameEngilsh.TabIndex = 7;
            // 
            // tboxGender
            // 
            this.tboxGender.Location = new System.Drawing.Point(226, 194);
            this.tboxGender.Name = "tboxGender";
            this.tboxGender.Size = new System.Drawing.Size(157, 22);
            this.tboxGender.TabIndex = 8;
            // 
            // tboxStarS
            // 
            this.tboxStarS.Location = new System.Drawing.Point(226, 246);
            this.tboxStarS.Name = "tboxStarS";
            this.tboxStarS.Size = new System.Drawing.Size(157, 22);
            this.tboxStarS.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "星座:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxStarS);
            this.Controls.Add(this.tboxGender);
            this.Controls.Add(this.tboxNameEngilsh);
            this.Controls.Add(this.tboxNaneC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqayHi);
            this.Controls.Add(this.btnSayHello);
            this.Name = "Form1";
            this.Text = "你好C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSqayHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNaneC;
        private System.Windows.Forms.TextBox tboxNameEngilsh;
        private System.Windows.Forms.TextBox tboxGender;
        private System.Windows.Forms.TextBox tboxStarS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

