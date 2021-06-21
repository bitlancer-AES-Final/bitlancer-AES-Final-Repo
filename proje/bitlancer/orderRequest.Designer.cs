
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
            this.w.Location = new System.Drawing.Point(28, 31);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(131, 21);
            this.w.TabIndex = 0;
            this.w.Text = "İstediğiniz Ürün:";
            // 
            // lblDesiredQuantity
            // 
            this.lblDesiredQuantity.AutoSize = true;
            this.lblDesiredQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredQuantity.Location = new System.Drawing.Point(28, 68);
            this.lblDesiredQuantity.Name = "lblDesiredQuantity";
            this.lblDesiredQuantity.Size = new System.Drawing.Size(142, 21);
            this.lblDesiredQuantity.TabIndex = 2;
            this.lblDesiredQuantity.Text = "İstediğiniz Miktar:";
            // 
            // txtDesiredQuantity
            // 
            this.txtDesiredQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDesiredQuantity.Location = new System.Drawing.Point(187, 67);
            this.txtDesiredQuantity.Name = "txtDesiredQuantity";
            this.txtDesiredQuantity.Size = new System.Drawing.Size(121, 22);
            this.txtDesiredQuantity.TabIndex = 3;
            // 
            // lblDesiredPrice
            // 
            this.lblDesiredPrice.AutoSize = true;
            this.lblDesiredPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredPrice.Location = new System.Drawing.Point(28, 107);
            this.lblDesiredPrice.Name = "lblDesiredPrice";
            this.lblDesiredPrice.Size = new System.Drawing.Size(117, 21);
            this.lblDesiredPrice.TabIndex = 2;
            this.lblDesiredPrice.Text = "İstenilen Fiyat:";
            // 
            // txtDesiredPrice
            // 
            this.txtDesiredPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDesiredPrice.Location = new System.Drawing.Point(187, 106);
            this.txtDesiredPrice.Name = "txtDesiredPrice";
            this.txtDesiredPrice.Size = new System.Drawing.Size(121, 22);
            this.txtDesiredPrice.TabIndex = 3;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(338, 29);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 99);
            this.btnOnay.TabIndex = 4;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // lblDesiredItem
            // 
            this.lblDesiredItem.AutoSize = true;
            this.lblDesiredItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesiredItem.Location = new System.Drawing.Point(183, 29);
            this.lblDesiredItem.Name = "lblDesiredItem";
            this.lblDesiredItem.Size = new System.Drawing.Size(0, 21);
            this.lblDesiredItem.TabIndex = 0;
            // 
            // orderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 162);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtDesiredPrice);
            this.Controls.Add(this.lblDesiredPrice);
            this.Controls.Add(this.txtDesiredQuantity);
            this.Controls.Add(this.lblDesiredQuantity);
            this.Controls.Add(this.lblDesiredItem);
            this.Controls.Add(this.w);
            this.Name = "orderRequest";
            this.Text = "orderRequest";
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