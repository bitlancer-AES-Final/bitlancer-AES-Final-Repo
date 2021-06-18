namespace bitlancer
{
    partial class Transfer
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
            this.grpBoxParaYukleme = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmParaBirimi = new System.Windows.Forms.ComboBox();
            this.grpBoxParaYukleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxParaYukleme
            // 
            this.grpBoxParaYukleme.Controls.Add(this.btnYukle);
            this.grpBoxParaYukleme.Controls.Add(this.lblMiktar);
            this.grpBoxParaYukleme.Controls.Add(this.numericUpDown1);
            this.grpBoxParaYukleme.Controls.Add(this.label1);
            this.grpBoxParaYukleme.Controls.Add(this.cbmParaBirimi);
            this.grpBoxParaYukleme.Location = new System.Drawing.Point(16, 15);
            this.grpBoxParaYukleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxParaYukleme.Name = "grpBoxParaYukleme";
            this.grpBoxParaYukleme.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxParaYukleme.Size = new System.Drawing.Size(1035, 102);
            this.grpBoxParaYukleme.TabIndex = 2;
            this.grpBoxParaYukleme.TabStop = false;
            this.grpBoxParaYukleme.Text = "Bakiye Yükleme";
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnYukle.Location = new System.Drawing.Point(676, 47);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(303, 33);
            this.btnYukle.TabIndex = 6;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(463, 27);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "Miktar:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(467, 47);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(201, 29);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para Birimi:";
            // 
            // cbmParaBirimi
            // 
            this.cbmParaBirimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbmParaBirimi.FormattingEnabled = true;
            this.cbmParaBirimi.Location = new System.Drawing.Point(8, 46);
            this.cbmParaBirimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmParaBirimi.Name = "cbmParaBirimi";
            this.cbmParaBirimi.Size = new System.Drawing.Size(449, 32);
            this.cbmParaBirimi.TabIndex = 2;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 134);
            this.Controls.Add(this.grpBoxParaYukleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.grpBoxParaYukleme.ResumeLayout(false);
            this.grpBoxParaYukleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxParaYukleme;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmParaBirimi;
    }
}