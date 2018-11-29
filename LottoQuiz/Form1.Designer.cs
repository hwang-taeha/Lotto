namespace LottoQuiz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.번호별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.번호별당첨횟수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.각번호를뽑은순서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전로또당첨확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.패턴분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.패턴분석ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.번호별ToolStripMenuItem,
            this.testToolStripMenuItem,
            this.패턴분석ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 번호별ToolStripMenuItem
            // 
            this.번호별ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.번호별당첨횟수ToolStripMenuItem,
            this.각번호를뽑은순서ToolStripMenuItem,
            this.이전로또당첨확인ToolStripMenuItem});
            this.번호별ToolStripMenuItem.Name = "번호별ToolStripMenuItem";
            this.번호별ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.번호별ToolStripMenuItem.Text = "번호별";
            // 
            // 번호별당첨횟수ToolStripMenuItem
            // 
            this.번호별당첨횟수ToolStripMenuItem.Name = "번호별당첨횟수ToolStripMenuItem";
            this.번호별당첨횟수ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.번호별당첨횟수ToolStripMenuItem.Text = "번호별 당첨 횟수";
            this.번호별당첨횟수ToolStripMenuItem.Click += new System.EventHandler(this.번호별당첨횟수ToolStripMenuItem_Click);
            // 
            // 각번호를뽑은순서ToolStripMenuItem
            // 
            this.각번호를뽑은순서ToolStripMenuItem.Name = "각번호를뽑은순서ToolStripMenuItem";
            this.각번호를뽑은순서ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.각번호를뽑은순서ToolStripMenuItem.Text = "각 번호를 뽑은 순서";
            this.각번호를뽑은순서ToolStripMenuItem.Click += new System.EventHandler(this.각번호를뽑은순서ToolStripMenuItem_Click);
            // 
            // 이전로또당첨확인ToolStripMenuItem
            // 
            this.이전로또당첨확인ToolStripMenuItem.Name = "이전로또당첨확인ToolStripMenuItem";
            this.이전로또당첨확인ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.이전로또당첨확인ToolStripMenuItem.Text = "이전 로또 당첨 확인";
            this.이전로또당첨확인ToolStripMenuItem.Click += new System.EventHandler(this.이전로또당첨확인ToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // 패턴분석ToolStripMenuItem
            // 
            this.패턴분석ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.패턴분석ToolStripMenuItem1});
            this.패턴분석ToolStripMenuItem.Name = "패턴분석ToolStripMenuItem";
            this.패턴분석ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.패턴분석ToolStripMenuItem.Text = "패턴분석";
            // 
            // 패턴분석ToolStripMenuItem1
            // 
            this.패턴분석ToolStripMenuItem1.Name = "패턴분석ToolStripMenuItem1";
            this.패턴분석ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.패턴분석ToolStripMenuItem1.Text = "패턴분석";
            this.패턴분석ToolStripMenuItem1.Click += new System.EventHandler(this.패턴분석ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 500);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 번호별ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 번호별당첨횟수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 각번호를뽑은순서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전로또당첨확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 패턴분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 패턴분석ToolStripMenuItem1;
    }
}

