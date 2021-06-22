
namespace bitlancer
{
    partial class orderRequest
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
            this.w = new System.Windows.Forms.Label();
            this.lblDesiredQuantity = new System.Windows.Forms.Label();
            this.txtDesiredQuantity = new System.Windows.Forms.TextBox();
            this.lblDesiredPrice = new System.Windows.Forms.Label();
            this.txtDesiredPrice = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.lblDesiredItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.w.Location = new System.Drawing.Point(37, 38);
            this.w.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(170, 27);
            this.w.TabIndex = 0;
            this.w.Text = "İstediğiniz Ürün:";
            // 
            // lblDesiredQuantity
            // 
            this.lblDesiredQuantity.AutoSize = true;
            this.lblDesiredQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredQuantity.Location = new System.Drawing.Point(37, 84);
            this.lblDesiredQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesiredQuantity.Name = "lblDesiredQuantity";
            this.lblDesiredQuantity.Size = new System.Drawing.Size(187, 27);
            this.lblDesiredQuantity.TabIndex = 2;
            this.lblDesiredQuantity.Text = "İstediğiniz Miktar:";
            // 
            // txtDesiredQuantity
            // 
            this.txtDesiredQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDesiredQuantity.Location = new System.Drawing.Point(232, 87);
            this.txtDesiredQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesiredQuantity.Name = "txtDesiredQuantity";
            this.txtDesiredQuantity.Size = new System.Drawing.Size(160, 26);
            this.txtDesiredQuantity.TabIndex = 3;
            // 
            // lblDesiredPrice
            // 
            this.lblDesiredPrice.AutoSize = true;
            this.lblDesiredPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredPrice.Location = new System.Drawing.Point(37, 132);
            this.lblDesiredPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesiredPrice.Name = "lblDesiredPrice";
            this.lblDesiredPrice.Size = new System.Drawing.Size(155, 27);
            this.lblDesiredPrice.TabIndex = 2;
            this.lblDesiredPrice.Text = "İstenilen Fiyat:";
            // 
            // txtDesiredPrice
            // 
            this.txtDesiredPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDesiredPrice.Location = new System.Drawing.Point(232, 132);
            this.txtDesiredPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesiredPrice.Name = "txtDesiredPrice";
            this.txtDesiredPrice.Size = new System.Drawing.Size(160, 26);
            this.txtDesiredPrice.TabIndex = 3;
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.Location = new System.Drawing.Point(451, 38);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(122, 122);
            this.btnOnay.TabIndex = 4;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // lblDesiredItem
            // 
            this.lblDesiredItem.AutoSize = true;
            this.lblDesiredItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredItem.Location = new System.Drawing.Point(244, 36);
            this.lblDesiredItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesiredItem.Name = "lblDesiredItem";
            this.lblDesiredItem.Size = new System.Drawing.Size(0, 27);
            this.lblDesiredItem.TabIndex = 0;
            // 
            // orderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(586, 223);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtDesiredPrice);
            this.Controls.Add(this.lblDesiredPrice);
            this.Controls.Add(this.txtDesiredQuantity);
            this.Controls.Add(this.lblDesiredQuantity);
            this.Controls.Add(this.lblDesiredItem);
            this.Controls.Add(this.w);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "orderRequest";
            this.Load += new System.EventHandler(this.orderRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label lblDesiredQuantity;
        private System.Windows.Forms.TextBox txtDesiredQuantity;
        private System.Windows.Forms.Label lblDesiredPrice;
        private System.Windows.Forms.TextBox txtDesiredPrice;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label lblDesiredItem;
    }
}