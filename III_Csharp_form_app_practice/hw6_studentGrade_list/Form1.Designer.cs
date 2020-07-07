namespace hw5_studentGrade
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
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnShowStatistic = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxChineseScore = new System.Windows.Forms.TextBox();
            this.tboxEnglishScore = new System.Windows.Forms.TextBox();
            this.tboxMathScore = new System.Windows.Forms.TextBox();
            this.labScore = new System.Windows.Forms.Label();
            this.labStatistic = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comlumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStatistic = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tboxSearchLower = new System.Windows.Forms.TextBox();
            this.tboxSearchUpper = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "數學 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "國文 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "英文 :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(23, 177);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "加入學生資料";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom.Location = new System.Drawing.Point(22, 241);
            this.btnAddRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(142, 27);
            this.btnAddRandom.TabIndex = 5;
            this.btnAddRandom.Text = "隨機儲存資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.btnAddRandom_Click);
            // 
            // btnShowStatistic
            // 
            this.btnShowStatistic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowStatistic.Location = new System.Drawing.Point(23, 304);
            this.btnShowStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowStatistic.Name = "btnShowStatistic";
            this.btnShowStatistic.Size = new System.Drawing.Size(82, 28);
            this.btnShowStatistic.TabIndex = 6;
            this.btnShowStatistic.Text = "各科統計";
            this.btnShowStatistic.UseVisualStyleBackColor = true;
            this.btnShowStatistic.Click += new System.EventHandler(this.btnShowStatistic_Click);
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxName.Location = new System.Drawing.Point(69, 5);
            this.tboxName.Margin = new System.Windows.Forms.Padding(2);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(106, 29);
            this.tboxName.TabIndex = 7;
            this.tboxName.Text = "皮卡丘";
            this.tboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxChineseScore
            // 
            this.tboxChineseScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxChineseScore.Location = new System.Drawing.Point(70, 48);
            this.tboxChineseScore.Margin = new System.Windows.Forms.Padding(2);
            this.tboxChineseScore.MaxLength = 3;
            this.tboxChineseScore.Name = "tboxChineseScore";
            this.tboxChineseScore.Size = new System.Drawing.Size(106, 29);
            this.tboxChineseScore.TabIndex = 8;
            this.tboxChineseScore.Text = "0";
            this.tboxChineseScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxEnglishScore
            // 
            this.tboxEnglishScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxEnglishScore.Location = new System.Drawing.Point(69, 91);
            this.tboxEnglishScore.Margin = new System.Windows.Forms.Padding(2);
            this.tboxEnglishScore.MaxLength = 3;
            this.tboxEnglishScore.Name = "tboxEnglishScore";
            this.tboxEnglishScore.Size = new System.Drawing.Size(106, 29);
            this.tboxEnglishScore.TabIndex = 9;
            this.tboxEnglishScore.Text = "0";
            this.tboxEnglishScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxMathScore
            // 
            this.tboxMathScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxMathScore.Location = new System.Drawing.Point(69, 134);
            this.tboxMathScore.Margin = new System.Windows.Forms.Padding(2);
            this.tboxMathScore.MaxLength = 3;
            this.tboxMathScore.Name = "tboxMathScore";
            this.tboxMathScore.Size = new System.Drawing.Size(106, 29);
            this.tboxMathScore.TabIndex = 10;
            this.tboxMathScore.Text = "0";
            this.tboxMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labScore
            // 
            this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.Location = new System.Drawing.Point(189, 9);
            this.labScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(520, 270);
            this.labScore.TabIndex = 0;
            // 
            // labStatistic
            // 
            this.labStatistic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labStatistic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatistic.Location = new System.Drawing.Point(189, 294);
            this.labStatistic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labStatistic.Name = "labStatistic";
            this.labStatistic.Size = new System.Drawing.Size(520, 149);
            this.labStatistic.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(23, 209);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 28);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "插入學生資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(109, 304);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 28);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.comlumnHeader3,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(196, 20);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 251);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            this.columnHeader2.Width = 50;
            // 
            // comlumnHeader3
            // 
            this.comlumnHeader3.Text = "英文";
            this.comlumnHeader3.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "數學";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "總分";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "平均";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "最低";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "最高";
            this.columnHeader7.Width = 80;
            // 
            // listViewStatistic
            // 
            this.listViewStatistic.BackColor = System.Drawing.SystemColors.Control;
            this.listViewStatistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewStatistic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewStatistic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStatistic.HideSelection = false;
            this.listViewStatistic.Location = new System.Drawing.Point(196, 298);
            this.listViewStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStatistic.Name = "listViewStatistic";
            this.listViewStatistic.Size = new System.Drawing.Size(504, 144);
            this.listViewStatistic.TabIndex = 15;
            this.listViewStatistic.UseCompatibleStateImageBehavior = false;
            this.listViewStatistic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "國文";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "英文";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "數學";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(23, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "搜尋國文成績範圍:";
            // 
            // tboxSearchLower
            // 
            this.tboxSearchLower.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxSearchLower.Location = new System.Drawing.Point(23, 373);
            this.tboxSearchLower.Margin = new System.Windows.Forms.Padding(2);
            this.tboxSearchLower.MaxLength = 3;
            this.tboxSearchLower.Name = "tboxSearchLower";
            this.tboxSearchLower.Size = new System.Drawing.Size(54, 29);
            this.tboxSearchLower.TabIndex = 17;
            this.tboxSearchLower.Text = "0";
            this.tboxSearchLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxSearchUpper
            // 
            this.tboxSearchUpper.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tboxSearchUpper.Location = new System.Drawing.Point(103, 373);
            this.tboxSearchUpper.Margin = new System.Windows.Forms.Padding(2);
            this.tboxSearchUpper.MaxLength = 3;
            this.tboxSearchUpper.Name = "tboxSearchUpper";
            this.tboxSearchUpper.Size = new System.Drawing.Size(54, 29);
            this.tboxSearchUpper.TabIndex = 18;
            this.tboxSearchUpper.Text = "100";
            this.tboxSearchUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(81, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(22, 410);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 27);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveLast.Location = new System.Drawing.Point(22, 272);
            this.btnRemoveLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(142, 28);
            this.btnRemoveLast.TabIndex = 21;
            this.btnRemoveLast.Text = "移除資料";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxSearchUpper);
            this.Controls.Add(this.tboxSearchLower);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewStatistic);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labStatistic);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.tboxMathScore);
            this.Controls.Add(this.tboxEnglishScore);
            this.Controls.Add(this.tboxChineseScore);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnShowStatistic);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "QAQ 成績紀錄表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnShowStatistic;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxChineseScore;
        private System.Windows.Forms.TextBox tboxEnglishScore;
        private System.Windows.Forms.TextBox tboxMathScore;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labStatistic;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader comlumnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listViewStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxSearchLower;
        private System.Windows.Forms.TextBox tboxSearchUpper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveLast;
    }
}

