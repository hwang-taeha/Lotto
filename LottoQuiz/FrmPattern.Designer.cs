namespace LottoQuiz
{
    partial class FrmPattern
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numDrwNo = new System.Windows.Forms.NumericUpDown();
            this.btnAdmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrwNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(295, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // numDrwNo
            // 
            this.numDrwNo.Location = new System.Drawing.Point(314, 13);
            this.numDrwNo.Maximum = new decimal(new int[] {
            834,
            0,
            0,
            0});
            this.numDrwNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDrwNo.Name = "numDrwNo";
            this.numDrwNo.Size = new System.Drawing.Size(120, 21);
            this.numDrwNo.TabIndex = 1;
            this.numDrwNo.Value = new decimal(new int[] {
            834,
            0,
            0,
            0});
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(314, 55);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdmit.TabIndex = 2;
            this.btnAdmit.Text = "검색";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // FrmPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 224);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.numDrwNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPattern";
            this.Text = "FrmPattern";
            this.Load += new System.EventHandler(this.FrmPattern_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrwNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numDrwNo;
        private System.Windows.Forms.Button btnAdmit;
    }
}