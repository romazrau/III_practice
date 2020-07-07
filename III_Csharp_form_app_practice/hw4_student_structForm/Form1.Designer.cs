namespace hw4_student_structForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowSaved = new System.Windows.Forms.Button();
            this.btnShowOutlier = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxChineseScore = new System.Windows.Forms.TextBox();
            this.tboxEnglishScore = new System.Windows.Forms.TextBox();
            this.tboxMathScore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labScore = new System.Windows.Forms.Label();
            this.labOutlier = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(37, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "數學 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "國文 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(37, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "英文 :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(43, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 79);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowSaved
            // 
            this.btnShowSaved.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSaved.Location = new System.Drawing.Point(222, 359);
            this.btnShowSaved.Name = "btnShowSaved";
            this.btnShowSaved.Size = new System.Drawing.Size(173, 79);
            this.btnShowSaved.TabIndex = 5;
            this.btnShowSaved.Text = "顯示儲存內容";
            this.btnShowSaved.UseVisualStyleBackColor = true;
            this.btnShowSaved.Click += new System.EventHandler(this.btnShowSaved_Click);
            // 
            // btnShowOutlier
            // 
            this.btnShowOutlier.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowOutlier.Location = new System.Drawing.Point(560, 359);
            this.btnShowOutlier.Name = "btnShowOutlier";
            this.btnShowOutlier.Size = new System.Drawing.Size(228, 79);
            this.btnShowOutlier.TabIndex = 6;
            this.btnShowOutlier.Text = "最高分/最低分科目";
            this.btnShowOutlier.UseVisualStyleBackColor = true;
            this.btnShowOutlier.Click += new System.EventHandler(this.btnShowOutlier_Click);
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxName.Location = new System.Drawing.Point(152, 36);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(242, 34);
            this.tboxName.TabIndex = 7;
            this.tboxName.Text = "皮卡丘";
            this.tboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxChineseScore
            // 
            this.tboxChineseScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxChineseScore.Location = new System.Drawing.Point(153, 103);
            this.tboxChineseScore.MaxLength = 3;
            this.tboxChineseScore.Name = "tboxChineseScore";
            this.tboxChineseScore.Size = new System.Drawing.Size(242, 34);
            this.tboxChineseScore.TabIndex = 8;
            this.tboxChineseScore.Text = "0";
            this.tboxChineseScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxEnglishScore
            // 
            this.tboxEnglishScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxEnglishScore.Location = new System.Drawing.Point(152, 172);
            this.tboxEnglishScore.MaxLength = 3;
            this.tboxEnglishScore.Name = "tboxEnglishScore";
            this.tboxEnglishScore.Size = new System.Drawing.Size(242, 34);
            this.tboxEnglishScore.TabIndex = 9;
            this.tboxEnglishScore.Text = "0";
            this.tboxEnglishScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxMathScore
            // 
            this.tboxMathScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxMathScore.Location = new System.Drawing.Point(152, 239);
            this.tboxMathScore.MaxLength = 3;
            this.tboxMathScore.Name = "tboxMathScore";
            this.tboxMathScore.Size = new System.Drawing.Size(242, 34);
            this.tboxMathScore.TabIndex = 10;
            this.tboxMathScore.Text = "0";
            this.tboxMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labOutlier);
            this.groupBox1.Controls.Add(this.labScore);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(436, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 329);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labScore
            // 
            this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.Location = new System.Drawing.Point(16, 34);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(329, 175);
            this.labScore.TabIndex = 0;
            this.labScore.Text = "姓名 :\r\n國文 :\r\n英文 :\r\n數學 :";
            // 
            // labOutlier
            // 
            this.labOutlier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOutlier.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOutlier.Location = new System.Drawing.Point(16, 218);
            this.labOutlier.Name = "labOutlier";
            this.labOutlier.Size = new System.Drawing.Size(329, 111);
            this.labOutlier.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxMathScore);
            this.Controls.Add(this.tboxEnglishScore);
            this.Controls.Add(this.tboxChineseScore);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnShowOutlier);
            this.Controls.Add(this.btnShowSaved);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student struct Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowSaved;
        private System.Windows.Forms.Button btnShowOutlier;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxChineseScore;
        private System.Windows.Forms.TextBox tboxEnglishScore;
        private System.Windows.Forms.TextBox tboxMathScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labOutlier;
        private System.Windows.Forms.Label labScore;
    }
}

