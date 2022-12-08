
namespace Đồ_án_RFID
{
    partial class Lichsuquet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lichsuquet));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtenkh = new System.Windows.Forms.ComboBox();
            this.btxemlichsuquet = new System.Windows.Forms.Button();
            this.dataGridView_LichSuQuet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuQuet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem lịch sử của Khách hàng";
            // 
            // cbtenkh
            // 
            this.cbtenkh.FormattingEnabled = true;
            this.cbtenkh.Location = new System.Drawing.Point(227, 17);
            this.cbtenkh.Name = "cbtenkh";
            this.cbtenkh.Size = new System.Drawing.Size(242, 21);
            this.cbtenkh.TabIndex = 2;
            // 
            // btxemlichsuquet
            // 
            this.btxemlichsuquet.Location = new System.Drawing.Point(499, 18);
            this.btxemlichsuquet.Name = "btxemlichsuquet";
            this.btxemlichsuquet.Size = new System.Drawing.Size(75, 23);
            this.btxemlichsuquet.TabIndex = 3;
            this.btxemlichsuquet.Text = "Xem";
            this.btxemlichsuquet.UseVisualStyleBackColor = true;
            this.btxemlichsuquet.Click += new System.EventHandler(this.btxemlichsuquet_Click);
            // 
            // dataGridView_LichSuQuet
            // 
            this.dataGridView_LichSuQuet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_LichSuQuet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LichSuQuet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LichSuQuet.Location = new System.Drawing.Point(16, 75);
            this.dataGridView_LichSuQuet.Name = "dataGridView_LichSuQuet";
            this.dataGridView_LichSuQuet.Size = new System.Drawing.Size(772, 363);
            this.dataGridView_LichSuQuet.TabIndex = 0;
            // 
            // Lichsuquet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_LichSuQuet);
            this.Controls.Add(this.btxemlichsuquet);
            this.Controls.Add(this.cbtenkh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lichsuquet";
            this.Text = "THỜI GIAN QUÉT THẺ";
            this.Load += new System.EventHandler(this.Lichsuquet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuQuet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtenkh;
        private System.Windows.Forms.Button btxemlichsuquet;
        private System.Windows.Forms.DataGridView dataGridView_LichSuQuet;
    }
}