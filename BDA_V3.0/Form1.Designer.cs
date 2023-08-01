
namespace BDA_V3._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnDetPostion = new System.Windows.Forms.Button();
            this.btnDetLenght = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFileType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Location = new System.Drawing.Point(8, 647);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 71);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "瀏覽";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRead.Location = new System.Drawing.Point(113, 647);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(109, 71);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "讀取";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(222, 647);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 71);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(333, 16);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1128, 614);
            this.pnlDisplay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "檔案類型";
            // 
            // lblFileNum
            // 
            this.lblFileNum.AutoSize = true;
            this.lblFileNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFileNum.Location = new System.Drawing.Point(194, 59);
            this.lblFileNum.Name = "lblFileNum";
            this.lblFileNum.Size = new System.Drawing.Size(86, 31);
            this.lblFileNum.TabIndex = 7;
            this.lblFileNum.Text = "未偵測";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "讀取狀態";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStatus.Location = new System.Drawing.Point(192, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 40);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "⚫";
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabase.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDatabase.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDatabase.Location = new System.Drawing.Point(620, 647);
            this.btnDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(267, 71);
            this.btnDatabase.TabIndex = 13;
            this.btnDatabase.Text = "數據狀態";
            this.btnDatabase.UseVisualStyleBackColor = false;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChart.Location = new System.Drawing.Point(907, 647);
            this.btnChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(267, 71);
            this.btnChart.TabIndex = 14;
            this.btnChart.Text = "圖表預覽";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSetting.Location = new System.Drawing.Point(1193, 647);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(267, 71);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "相關設定";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnDetPostion
            // 
            this.btnDetPostion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetPostion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetPostion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetPostion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetPostion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetPostion.Location = new System.Drawing.Point(20, 397);
            this.btnDetPostion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetPostion.Name = "btnDetPostion";
            this.btnDetPostion.Size = new System.Drawing.Size(293, 71);
            this.btnDetPostion.TabIndex = 16;
            this.btnDetPostion.Text = "自動偵測位置";
            this.btnDetPostion.UseVisualStyleBackColor = false;
            this.btnDetPostion.Click += new System.EventHandler(this.btnDetPostion_Click);
            // 
            // btnDetLenght
            // 
            this.btnDetLenght.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetLenght.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetLenght.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetLenght.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetLenght.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetLenght.Location = new System.Drawing.Point(20, 502);
            this.btnDetLenght.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetLenght.Name = "btnDetLenght";
            this.btnDetLenght.Size = new System.Drawing.Size(293, 71);
            this.btnDetLenght.TabIndex = 17;
            this.btnDetLenght.Text = "自動偵測行數";
            this.btnDetLenght.UseVisualStyleBackColor = false;
            this.btnDetLenght.Click += new System.EventHandler(this.btnDetLenght_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHome.Location = new System.Drawing.Point(333, 647);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(267, 71);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "主畫面";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 602);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(319, 38);
            this.progressBar1.TabIndex = 19;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFileType.Location = new System.Drawing.Point(192, 179);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(86, 31);
            this.lblFileType.TabIndex = 21;
            this.lblFileType.Text = "未偵測";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "檔案數量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 740);
            this.Controls.Add(this.lblFileType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDetLenght);
            this.Controls.Add(this.btnDetPostion);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFileNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "秉翰集團出品";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnDetPostion;
        private System.Windows.Forms.Button btnDetLenght;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label label3;
    }
}

