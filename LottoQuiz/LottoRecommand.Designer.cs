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
            this.dgvNumvers = new System.Windows.Forms.DataGridView();
            this.btnRecommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumvers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumvers
            // 
            this.dgvNumvers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumvers.Location = new System.Drawing.Point(12, 29);
            this.dgvNumvers.Name = "dgvNumvers";
            this.dgvNumvers.RowTemplate.Height = 23;
            this.dgvNumvers.Size = new System.Drawing.Size(473, 204);
            this.dgvNumvers.TabIndex = 0;
            // 
            // btnRecommand
            // 
            this.btnRecommand.Location = new System.Drawing.Point(12, 239);
            this.btnRecommand.Name = "btnRecommand";
            this.btnRecommand.Size = new System.Drawing.Size(115, 46);
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
            this.Controls.Add(this.dgvNumvers);
            this.Name = "LottoRecommand";
            this.Text = "LottoRecommand";
            this.Load += new System.EventHandler(this.LottoRecommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumvers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumvers;
        private System.Windows.Forms.Button btnRecommand;
    }
}