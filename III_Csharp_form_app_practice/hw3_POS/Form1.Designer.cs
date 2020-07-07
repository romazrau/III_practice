namespace Hw3_POS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnPayCard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.btnM520 = new System.Windows.Forms.Button();
            this.btnM270 = new System.Windows.Forms.Button();
            this.btnM710 = new System.Windows.Forms.Button();
            this.btnM130 = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 431);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜單 Menu";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 261);
            this.label2.TabIndex = 1;
            this.label2.Text = "購物清單 List";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(486, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "付款方式";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(486, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 79);
            this.label4.TabIndex = 3;
            this.label4.Text = "總金額 Total Price";
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(495, 395);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(136, 30);
            this.btnPayCash.TabIndex = 4;
            this.btnPayCash.Text = "現金";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // btnPayCard
            // 
            this.btnPayCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayCard.Location = new System.Drawing.Point(637, 395);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(142, 30);
            this.btnPayCard.TabIndex = 5;
            this.btnPayCard.Text = "信用卡 ";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayCard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "刷卡享9折優惠！！";
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotal.Location = new System.Drawing.Point(495, 312);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(284, 36);
            this.labTotal.TabIndex = 7;
            this.labTotal.Text = "NT$ 0";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnM520
            // 
            this.btnM520.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnM520.Image = ((System.Drawing.Image)(resources.GetObject("btnM520.Image")));
            this.btnM520.Location = new System.Drawing.Point(251, 41);
            this.btnM520.Name = "btnM520";
            this.btnM520.Size = new System.Drawing.Size(212, 190);
            this.btnM520.TabIndex = 12;
            this.btnM520.Text = "帕華洛帝義大利麵 $520";
            this.btnM520.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnM520.UseVisualStyleBackColor = true;
            this.btnM520.Click += new System.EventHandler(this.btnM520_Click);
            // 
            // btnM270
            // 
            this.btnM270.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnM270.Image = ((System.Drawing.Image)(resources.GetObject("btnM270.Image")));
            this.btnM270.Location = new System.Drawing.Point(33, 41);
            this.btnM270.Name = "btnM270";
            this.btnM270.Size = new System.Drawing.Size(212, 190);
            this.btnM270.TabIndex = 13;
            this.btnM270.Text = "奴爾哈赤火鍋 $270";
            this.btnM270.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnM270.UseVisualStyleBackColor = true;
            this.btnM270.Click += new System.EventHandler(this.btnM270_Click);
            // 
            // btnM710
            // 
            this.btnM710.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnM710.Image = ((System.Drawing.Image)(resources.GetObject("btnM710.Image")));
            this.btnM710.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnM710.Location = new System.Drawing.Point(33, 234);
            this.btnM710.Name = "btnM710";
            this.btnM710.Size = new System.Drawing.Size(212, 190);
            this.btnM710.TabIndex = 14;
            this.btnM710.Text = "普通的飯糰 $710";
            this.btnM710.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnM710.UseVisualStyleBackColor = true;
            this.btnM710.Click += new System.EventHandler(this.btnM710_Click);
            // 
            // btnM130
            // 
            this.btnM130.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnM130.Image = ((System.Drawing.Image)(resources.GetObject("btnM130.Image")));
            this.btnM130.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnM130.Location = new System.Drawing.Point(251, 234);
            this.btnM130.Name = "btnM130";
            this.btnM130.Size = new System.Drawing.Size(212, 190);
            this.btnM130.TabIndex = 15;
            this.btnM130.Text = "帝王拿波海帶湯 $130";
            this.btnM130.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnM130.UseVisualStyleBackColor = true;
            this.btnM130.Click += new System.EventHandler(this.btnM130_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(495, 41);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(284, 219);
            this.labList.TabIndex = 16;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(687, 217);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(83, 34);
            this.btnClearList.TabIndex = 17;
            this.btnClearList.Text = "清除";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.btnM130);
            this.Controls.Add(this.btnM710);
            this.Controls.Add(this.btnM270);
            this.Controls.Add(this.btnM520);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPayCard);
            this.Controls.Add(this.btnPayCash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bar POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnPayCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnM520;
        private System.Windows.Forms.Button btnM270;
        private System.Windows.Forms.Button btnM710;
        private System.Windows.Forms.Button btnM130;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnClearList;
    }
}

