namespace LottoQuiz
{
    partial class Frmcontinuity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcontinuity));
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAll = new System.Windows.Forms.Button();
            this.btnfront = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 12);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 23;
            this.dgvView.Size = new System.Drawing.Size(596, 419);
            this.dgvView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lo");
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(713, 305);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "전체보기";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnfront
            // 
            this.btnfront.Location = new System.Drawing.Point(713, 362);
            this.btnfront.Name = "btnfront";
            this.btnfront.Size = new System.Drawing.Size(75, 69);
            this.btnfront.TabIndex = 2;
            this.btnfront.Text = ">>";
            this.btnfront.UseVisualStyleBackColor = true;
            this.btnfront.Click += new System.EventHandler(this.btnfront_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(614, 362);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 69);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "<<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Frmcontinuity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfront);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dgvView);
            this.Name = "Frmcontinuity";
            this.Text = "연속번호 확인";
            this.Load += new System.EventHandler(this.Frmcontinuity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnfront;
        private System.Windows.Forms.Button btnback;
    }
}