namespace hw7_Method
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
            this.labNumArray = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labShowResult = new System.Windows.Forms.Label();
            this.tboxNum = new System.Windows.Forms.TextBox();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetOdd = new System.Windows.Forms.Button();
            this.btnGetMaxMin = new System.Windows.Forms.Button();
            this.tboxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetLongestString = new System.Windows.Forms.Button();
            this.btnGetNumOfC = new System.Windows.Forms.Button();
            this.btnAddString = new System.Windows.Forms.Button();
            this.labStringArray = new System.Windows.Forms.Label();
            this.btnArrayMin = new System.Windows.Forms.Button();
            this.btnArrayMax = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.btnArraySwap = new System.Windows.Forms.Button();
            this.btnGraph1001 = new System.Windows.Forms.Button();
            this.btnGraph1010 = new System.Windows.Forms.Button();
            this.btnGraph0110 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array :";
            // 
            // labNumArray
            // 
            this.labNumArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labNumArray.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumArray.Location = new System.Drawing.Point(87, 137);
            this.labNumArray.Name = "labNumArray";
            this.labNumArray.Size = new System.Drawing.Size(814, 24);
            this.labNumArray.TabIndex = 1;
            this.labNumArray.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(528, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result :";
            // 
            // labShowResult
            // 
            this.labShowResult.AutoSize = true;
            this.labShowResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labShowResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labShowResult.Location = new System.Drawing.Point(611, 340);
            this.labShowResult.Name = "labShowResult";
            this.labShowResult.Size = new System.Drawing.Size(32, 17);
            this.labShowResult.TabIndex = 3;
            this.labShowResult.Text = "null";
            // 
            // tboxNum
            // 
            this.tboxNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxNum.Location = new System.Drawing.Point(14, 188);
            this.tboxNum.Name = "tboxNum";
            this.tboxNum.Size = new System.Drawing.Size(108, 29);
            this.tboxNum.TabIndex = 4;
            // 
            // btnAddNum
            // 
            this.btnAddNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddNum.Location = new System.Drawing.Point(128, 188);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(55, 29);
            this.btnAddNum.TabIndex = 5;
            this.btnAddNum.Text = "存入";
            this.btnAddNum.UseMnemonic = false;
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(12, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "此數是否為偶數";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetOdd
            // 
            this.btnGetOdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetOdd.Location = new System.Drawing.Point(378, 188);
            this.btnGetOdd.Name = "btnGetOdd";
            this.btnGetOdd.Size = new System.Drawing.Size(141, 63);
            this.btnGetOdd.TabIndex = 7;
            this.btnGetOdd.Text = "統計奇偶數";
            this.btnGetOdd.UseMnemonic = false;
            this.btnGetOdd.UseVisualStyleBackColor = true;
            this.btnGetOdd.Click += new System.EventHandler(this.btnGetOdd_Click);
            // 
            // btnGetMaxMin
            // 
            this.btnGetMaxMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetMaxMin.Location = new System.Drawing.Point(378, 257);
            this.btnGetMaxMin.Name = "btnGetMaxMin";
            this.btnGetMaxMin.Size = new System.Drawing.Size(141, 63);
            this.btnGetMaxMin.TabIndex = 8;
            this.btnGetMaxMin.Text = "最大/最小值";
            this.btnGetMaxMin.UseMnemonic = false;
            this.btnGetMaxMin.UseVisualStyleBackColor = true;
            this.btnGetMaxMin.Click += new System.EventHandler(this.btnGetMaxMin_Click);
            // 
            // tboxString
            // 
            this.tboxString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxString.Location = new System.Drawing.Point(20, 49);
            this.tboxString.Name = "tboxString";
            this.tboxString.Size = new System.Drawing.Size(108, 29);
            this.tboxString.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "字串:";
            // 
            // btnGetLongestString
            // 
            this.btnGetLongestString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetLongestString.Location = new System.Drawing.Point(222, 49);
            this.btnGetLongestString.Name = "btnGetLongestString";
            this.btnGetLongestString.Size = new System.Drawing.Size(141, 63);
            this.btnGetLongestString.TabIndex = 16;
            this.btnGetLongestString.Text = "最長的名字";
            this.btnGetLongestString.UseMnemonic = false;
            this.btnGetLongestString.UseVisualStyleBackColor = true;
            this.btnGetLongestString.Click += new System.EventHandler(this.btnGetLongestString_Click);
            // 
            // btnGetNumOfC
            // 
            this.btnGetNumOfC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetNumOfC.Location = new System.Drawing.Point(378, 49);
            this.btnGetNumOfC.Name = "btnGetNumOfC";
            this.btnGetNumOfC.Size = new System.Drawing.Size(141, 63);
            this.btnGetNumOfC.TabIndex = 17;
            this.btnGetNumOfC.Text = "C/c有幾個";
            this.btnGetNumOfC.UseMnemonic = false;
            this.btnGetNumOfC.UseVisualStyleBackColor = true;
            this.btnGetNumOfC.Click += new System.EventHandler(this.btnGetNumOfC_Click);
            // 
            // btnAddString
            // 
            this.btnAddString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddString.Location = new System.Drawing.Point(134, 49);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(55, 29);
            this.btnAddString.TabIndex = 18;
            this.btnAddString.Text = "存入";
            this.btnAddString.UseMnemonic = false;
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // labStringArray
            // 
            this.labStringArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labStringArray.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStringArray.Location = new System.Drawing.Point(75, 9);
            this.labStringArray.Name = "labStringArray";
            this.labStringArray.Size = new System.Drawing.Size(814, 24);
            this.labStringArray.TabIndex = 19;
            this.labStringArray.Text = "null";
            // 
            // btnArrayMin
            // 
            this.btnArrayMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrayMin.Location = new System.Drawing.Point(222, 395);
            this.btnArrayMin.Name = "btnArrayMin";
            this.btnArrayMin.Size = new System.Drawing.Size(141, 63);
            this.btnArrayMin.TabIndex = 21;
            this.btnArrayMin.Text = "Min";
            this.btnArrayMin.UseMnemonic = false;
            this.btnArrayMin.UseVisualStyleBackColor = true;
            this.btnArrayMin.Click += new System.EventHandler(this.btnArrayMin_Click);
            // 
            // btnArrayMax
            // 
            this.btnArrayMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrayMax.Location = new System.Drawing.Point(222, 326);
            this.btnArrayMax.Name = "btnArrayMax";
            this.btnArrayMax.Size = new System.Drawing.Size(141, 63);
            this.btnArrayMax.TabIndex = 20;
            this.btnArrayMax.Text = "Max";
            this.btnArrayMax.UseMnemonic = false;
            this.btnArrayMax.UseVisualStyleBackColor = true;
            this.btnArrayMax.Click += new System.EventHandler(this.btnArrayMax_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArraySum.Location = new System.Drawing.Point(222, 257);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(141, 63);
            this.btnArraySum.TabIndex = 23;
            this.btnArraySum.Text = "Sum";
            this.btnArraySum.UseMnemonic = false;
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // btnArraySwap
            // 
            this.btnArraySwap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArraySwap.Location = new System.Drawing.Point(222, 188);
            this.btnArraySwap.Name = "btnArraySwap";
            this.btnArraySwap.Size = new System.Drawing.Size(141, 63);
            this.btnArraySwap.TabIndex = 22;
            this.btnArraySwap.Text = "Swap";
            this.btnArraySwap.UseMnemonic = false;
            this.btnArraySwap.UseVisualStyleBackColor = true;
            this.btnArraySwap.Click += new System.EventHandler(this.btnArraySwap_Click);
            // 
            // btnGraph1001
            // 
            this.btnGraph1001.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGraph1001.Location = new System.Drawing.Point(613, 188);
            this.btnGraph1001.Name = "btnGraph1001";
            this.btnGraph1001.Size = new System.Drawing.Size(141, 63);
            this.btnGraph1001.TabIndex = 24;
            this.btnGraph1001.Text = "10x10，邊1內0";
            this.btnGraph1001.UseMnemonic = false;
            this.btnGraph1001.UseVisualStyleBackColor = true;
            this.btnGraph1001.Click += new System.EventHandler(this.btnGraph1001_Click);
            // 
            // btnGraph1010
            // 
            this.btnGraph1010.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGraph1010.Location = new System.Drawing.Point(760, 188);
            this.btnGraph1010.Name = "btnGraph1010";
            this.btnGraph1010.Size = new System.Drawing.Size(141, 63);
            this.btnGraph1010.TabIndex = 25;
            this.btnGraph1010.Text = "10x10，梅花座";
            this.btnGraph1010.UseMnemonic = false;
            this.btnGraph1010.UseVisualStyleBackColor = true;
            this.btnGraph1010.Click += new System.EventHandler(this.btnGraph1010_Click);
            // 
            // btnGraph0110
            // 
            this.btnGraph0110.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGraph0110.Location = new System.Drawing.Point(613, 257);
            this.btnGraph0110.Name = "btnGraph0110";
            this.btnGraph0110.Size = new System.Drawing.Size(141, 63);
            this.btnGraph0110.TabIndex = 26;
            this.btnGraph0110.Text = "10x10，邊0內1";
            this.btnGraph0110.UseMnemonic = false;
            this.btnGraph0110.UseVisualStyleBackColor = true;
            this.btnGraph0110.Click += new System.EventHandler(this.btnGraph0110_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 537);
            this.Controls.Add(this.btnGraph0110);
            this.Controls.Add(this.btnGraph1010);
            this.Controls.Add(this.btnGraph1001);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnArraySwap);
            this.Controls.Add(this.btnArrayMin);
            this.Controls.Add(this.btnArrayMax);
            this.Controls.Add(this.labStringArray);
            this.Controls.Add(this.btnAddString);
            this.Controls.Add(this.btnGetNumOfC);
            this.Controls.Add(this.btnGetLongestString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxString);
            this.Controls.Add(this.btnGetMaxMin);
            this.Controls.Add(this.btnGetOdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddNum);
            this.Controls.Add(this.tboxNum);
            this.Controls.Add(this.labShowResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNumArray);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "陣列 ban ban ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNumArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labShowResult;
        private System.Windows.Forms.TextBox tboxNum;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetOdd;
        private System.Windows.Forms.Button btnGetMaxMin;
        private System.Windows.Forms.TextBox tboxString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetLongestString;
        private System.Windows.Forms.Button btnGetNumOfC;
        private System.Windows.Forms.Button btnAddString;
        private System.Windows.Forms.Label labStringArray;
        private System.Windows.Forms.Button btnArrayMin;
        private System.Windows.Forms.Button btnArrayMax;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.Button btnArraySwap;
        private System.Windows.Forms.Button btnGraph1001;
        private System.Windows.Forms.Button btnGraph1010;
        private System.Windows.Forms.Button btnGraph0110;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

