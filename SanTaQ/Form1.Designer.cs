namespace SanTaQ
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.buttonAns1 = new System.Windows.Forms.Button();
            this.buttonAns2 = new System.Windows.Forms.Button();
            this.buttonAns3 = new System.Windows.Forms.Button();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelOK = new System.Windows.Forms.Label();
            this.labelNG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textQuestion
            // 
            this.textQuestion.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textQuestion.Location = new System.Drawing.Point(1, 33);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.ReadOnly = true;
            this.textQuestion.Size = new System.Drawing.Size(785, 344);
            this.textQuestion.TabIndex = 1;
            this.textQuestion.Text = "012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
    "123456789012345678901234\r\n1 \r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n0\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r" +
    "\n9\r\n0\r\n1\r\n2\r\n3\r\n4";
            // 
            // buttonAns1
            // 
            this.buttonAns1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAns1.Location = new System.Drawing.Point(2, 383);
            this.buttonAns1.Name = "buttonAns1";
            this.buttonAns1.Size = new System.Drawing.Size(783, 55);
            this.buttonAns1.TabIndex = 2;
            this.buttonAns1.Text = "回答1";
            this.buttonAns1.UseVisualStyleBackColor = true;
            this.buttonAns1.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // buttonAns2
            // 
            this.buttonAns2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAns2.Location = new System.Drawing.Point(1, 444);
            this.buttonAns2.Name = "buttonAns2";
            this.buttonAns2.Size = new System.Drawing.Size(784, 55);
            this.buttonAns2.TabIndex = 3;
            this.buttonAns2.Text = "回答2";
            this.buttonAns2.UseVisualStyleBackColor = true;
            this.buttonAns2.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // buttonAns3
            // 
            this.buttonAns3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAns3.Location = new System.Drawing.Point(1, 505);
            this.buttonAns3.Name = "buttonAns3";
            this.buttonAns3.Size = new System.Drawing.Size(784, 55);
            this.buttonAns3.TabIndex = 4;
            this.buttonAns3.Text = "回答3";
            this.buttonAns3.UseVisualStyleBackColor = true;
            this.buttonAns3.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.textTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textTitle.Location = new System.Drawing.Point(0, 1);
            this.textTitle.Name = "textTitle";
            this.textTitle.ReadOnly = true;
            this.textTitle.Size = new System.Drawing.Size(785, 34);
            this.textTitle.TabIndex = 5;
            this.textTitle.Text = "3択クイズ　San-Ta-Q";
            this.textTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOK
            // 
            this.labelOK.AutoSize = true;
            this.labelOK.BackColor = System.Drawing.Color.Transparent;
            this.labelOK.Font = new System.Drawing.Font("MS UI Gothic", 200F);
            this.labelOK.ForeColor = System.Drawing.Color.Blue;
            this.labelOK.Location = new System.Drawing.Point(217, 75);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(379, 267);
            this.labelOK.TabIndex = 6;
            this.labelOK.Text = "〇";
            this.labelOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOK.Visible = false;
            // 
            // labelNG
            // 
            this.labelNG.AutoSize = true;
            this.labelNG.BackColor = System.Drawing.Color.Transparent;
            this.labelNG.Font = new System.Drawing.Font("MS UI Gothic", 200F);
            this.labelNG.ForeColor = System.Drawing.Color.Red;
            this.labelNG.Location = new System.Drawing.Point(217, 75);
            this.labelNG.Name = "labelNG";
            this.labelNG.Size = new System.Drawing.Size(379, 267);
            this.labelNG.TabIndex = 7;
            this.labelNG.Text = "✖";
            this.labelNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNG.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelNG);
            this.Controls.Add(this.labelOK);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.buttonAns3);
            this.Controls.Add(this.buttonAns2);
            this.Controls.Add(this.buttonAns1);
            this.Controls.Add(this.textQuestion);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "3択クイズ San-Ta-Q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonAns1;
        public System.Windows.Forms.TextBox textQuestion;
        public System.Windows.Forms.Button buttonAns2;
        public System.Windows.Forms.Button buttonAns3;
        public System.Windows.Forms.TextBox textTitle;
        public System.Windows.Forms.Label labelOK;
        public System.Windows.Forms.Label labelNG;
    }
}

