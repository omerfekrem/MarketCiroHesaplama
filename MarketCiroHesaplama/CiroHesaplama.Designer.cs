namespace MarketCiroHesaplama
{
    partial class CiroRaporlama
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
            this.subeAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCiro = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ciroText = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.excelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCiro)).BeginInit();
            this.SuspendLayout();
            // 
            // subeAdi
            // 
            this.subeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeAdi.FormattingEnabled = true;
            this.subeAdi.Location = new System.Drawing.Point(95, 17);
            this.subeAdi.Name = "subeAdi";
            this.subeAdi.Size = new System.Drawing.Size(121, 24);
            this.subeAdi.TabIndex = 0;
            this.subeAdi.SelectedIndexChanged += new System.EventHandler(this.subeAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şube Seç :";
            // 
            // dgCiro
            // 
            this.dgCiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCiro.Location = new System.Drawing.Point(225, 17);
            this.dgCiro.Name = "dgCiro";
            this.dgCiro.ReadOnly = true;
            this.dgCiro.Size = new System.Drawing.Size(563, 421);
            this.dgCiro.TabIndex = 2;
            this.dgCiro.SelectionChanged += new System.EventHandler(this.dgCiro_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciro :";
            // 
            // ciroText
            // 
            this.ciroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ciroText.Location = new System.Drawing.Point(95, 49);
            this.ciroText.Name = "ciroText";
            this.ciroText.Size = new System.Drawing.Size(121, 23);
            this.ciroText.TabIndex = 4;
            this.ciroText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(157, 83);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(59, 23);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(95, 83);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(56, 23);
            this.silBtn.TabIndex = 6;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Location = new System.Drawing.Point(12, 83);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(75, 23);
            this.duzenleBtn.TabIndex = 7;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.UseVisualStyleBackColor = true;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(12, 415);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(75, 23);
            this.excelBtn.TabIndex = 8;
            this.excelBtn.Text = "Excel Rapor";
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // CiroRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excelBtn);
            this.Controls.Add(this.duzenleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.ciroText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subeAdi);
            this.Name = "CiroRaporlama";
            this.Text = "Ciro Raporlama";
            ((System.ComponentModel.ISupportInitialize)(this.dgCiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ciroText;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button duzenleBtn;
        private System.Windows.Forms.Button excelBtn;
    }
}

