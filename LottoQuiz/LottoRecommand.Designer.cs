namespace LottoQuiz
{
    partial class LottoRecommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRecommandNums = new System.Windows.Forms.DataGridView();
            this.btnRecommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommandNums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecommandNums
            // 
            this.dgvRecommandNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommandNums.Location = new System.Drawing.Point(32, 39);
            this.dgvRecommandNums.Name = "dgvRecommandNums";
            this.dgvRecommandNums.RowTemplate.Height = 23;
            this.dgvRecommandNums.Size = new System.Drawing.Size(653, 213);
            this.dgvRecommandNums.TabIndex = 0;
            // 
            // btnRecommand
            // 
            this.btnRecommand.Location = new System.Drawing.Point(32, 272);
            this.btnRecommand.Name = "btnRecommand";
            this.btnRecommand.Size = new System.Drawing.Size(145, 46);
            this.btnRecommand.TabIndex = 1;
            this.btnRecommand.Text = "추천번호 생성";
            this.btnRecommand.UseVisualStyleBackColor = true;
            this.btnRecommand.Click += new System.EventHandler(this.btnRecommand_Click);
            // 
            // LottoRecommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecommand);
            this.Controls.Add(this.dgvRecommandNums);
            this.Name = "LottoRecommand";
            this.Text = "LottoRecommand";
            this.Load += new System.EventHandler(this.LottoRecommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommandNums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecommandNums;
        private System.Windows.Forms.Button btnRecommand;
    }
}