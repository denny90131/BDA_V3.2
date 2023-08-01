
namespace BDA_V3._0
{
    partial class ucSetting
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataLenght = new System.Windows.Forms.TextBox();
            this.txtMaxTPostion = new System.Windows.Forms.TextBox();
            this.txtMinVPostion = new System.Windows.Forms.TextBox();
            this.txtMaxVPostion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(13, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(323, 46);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "確認";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "最高電壓位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "最低電壓位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "最高溫度位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "資料長度";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataLenght);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtMaxTPostion);
            this.groupBox1.Controls.Add(this.txtMinVPostion);
            this.groupBox1.Controls.Add(this.txtMaxVPostion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 463);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "讀取設置";
            // 
            // txtDataLenght
            // 
            this.txtDataLenght.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDataLenght.ForeColor = System.Drawing.Color.Yellow;
            this.txtDataLenght.Location = new System.Drawing.Point(180, 334);
            this.txtDataLenght.Name = "txtDataLenght";
            this.txtDataLenght.Size = new System.Drawing.Size(100, 39);
            this.txtDataLenght.TabIndex = 8;
            this.txtDataLenght.Text = "0";
            this.txtDataLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxTPostion
            // 
            this.txtMaxTPostion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMaxTPostion.ForeColor = System.Drawing.Color.Yellow;
            this.txtMaxTPostion.Location = new System.Drawing.Point(180, 238);
            this.txtMaxTPostion.Name = "txtMaxTPostion";
            this.txtMaxTPostion.Size = new System.Drawing.Size(100, 39);
            this.txtMaxTPostion.TabIndex = 7;
            this.txtMaxTPostion.Text = "0";
            this.txtMaxTPostion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinVPostion
            // 
            this.txtMinVPostion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMinVPostion.ForeColor = System.Drawing.Color.Yellow;
            this.txtMinVPostion.Location = new System.Drawing.Point(180, 142);
            this.txtMinVPostion.Name = "txtMinVPostion";
            this.txtMinVPostion.Size = new System.Drawing.Size(100, 39);
            this.txtMinVPostion.TabIndex = 6;
            this.txtMinVPostion.Text = "0";
            this.txtMinVPostion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxVPostion
            // 
            this.txtMaxVPostion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMaxVPostion.ForeColor = System.Drawing.Color.Yellow;
            this.txtMaxVPostion.Location = new System.Drawing.Point(180, 46);
            this.txtMaxVPostion.Name = "txtMaxVPostion";
            this.txtMaxVPostion.Size = new System.Drawing.Size(100, 39);
            this.txtMaxVPostion.TabIndex = 5;
            this.txtMaxVPostion.Text = "0";
            this.txtMaxVPostion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucSetting";
            this.Size = new System.Drawing.Size(1015, 526);
            this.Load += new System.EventHandler(this.ucSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDataLenght;
        private System.Windows.Forms.TextBox txtMaxTPostion;
        private System.Windows.Forms.TextBox txtMinVPostion;
        private System.Windows.Forms.TextBox txtMaxVPostion;
    }
}
