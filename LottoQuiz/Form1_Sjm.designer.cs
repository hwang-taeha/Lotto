namespace LottoQuiz
{
    partial class Form1_Sjm
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
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.txtNo4 = new System.Windows.Forms.TextBox();
            this.txtNo3 = new System.Windows.Forms.TextBox();
            this.txtNo6 = new System.Windows.Forms.TextBox();
            this.txtNo5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DBGridView = new System.Windows.Forms.DataGridView();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNo2
            // 
            this.txtNo2.Location = new System.Drawing.Point(82, 71);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(23, 21);
            this.txtNo2.TabIndex = 1;
            this.txtNo2.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // txtNo4
            // 
            this.txtNo4.Location = new System.Drawing.Point(140, 71);
            this.txtNo4.Name = "txtNo4";
            this.txtNo4.Size = new System.Drawing.Size(23, 21);
            this.txtNo4.TabIndex = 3;
            this.txtNo4.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // txtNo3
            // 
            this.txtNo3.Location = new System.Drawing.Point(111, 71);
            this.txtNo3.Name = "txtNo3";
            this.txtNo3.Size = new System.Drawing.Size(23, 21);
            this.txtNo3.TabIndex = 2;
            this.txtNo3.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // txtNo6
            // 
            this.txtNo6.Location = new System.Drawing.Point(198, 71);
            this.txtNo6.Name = "txtNo6";
            this.txtNo6.Size = new System.Drawing.Size(23, 21);
            this.txtNo6.TabIndex = 5;
            this.txtNo6.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // txtNo5
            // 
            this.txtNo5.Location = new System.Drawing.Point(169, 71);
            this.txtNo5.Name = "txtNo5";
            this.txtNo5.Size = new System.Drawing.Size(23, 21);
            this.txtNo5.TabIndex = 4;
            this.txtNo5.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "당첨번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "결과확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBGridView
            // 
            this.DBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGridView.Location = new System.Drawing.Point(12, 116);
            this.DBGridView.Name = "DBGridView";
            this.DBGridView.RowTemplate.Height = 23;
            this.DBGridView.Size = new System.Drawing.Size(449, 315);
            this.DBGridView.TabIndex = 16;
            // 
            // txtNo1
            // 
            this.txtNo1.Location = new System.Drawing.Point(53, 71);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(23, 21);
            this.txtNo1.TabIndex = 0;
            this.txtNo1.TextChanged += new System.EventHandler(this.txtNo1_TextChanged_1);
            // 
            // Form1_Sjm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 444);
            this.Controls.Add(this.DBGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNo6);
            this.Controls.Add(this.txtNo5);
            this.Controls.Add(this.txtNo4);
            this.Controls.Add(this.txtNo3);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Name = "Form1_Sjm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Sjm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.TextBox txtNo4;
        private System.Windows.Forms.TextBox txtNo3;
        private System.Windows.Forms.TextBox txtNo6;
        private System.Windows.Forms.TextBox txtNo5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DBGridView;
        private System.Windows.Forms.TextBox txtNo1;
    }
}

