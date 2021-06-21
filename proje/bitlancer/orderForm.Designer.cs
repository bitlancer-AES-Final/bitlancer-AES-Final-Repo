namespace bitlancer
{
    partial class orderForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.quantity = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.valTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.transferlerDatgrid = new System.Windows.Forms.DataGridView();
            this.lblSonEmirler = new System.Windows.Forms.Label();
            this.orderProcces = new System.ComponentModel.BackgroundWorker();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.btnIstek = new System.Windows.Forms.Button();
            this.picBoxYuklenme = new System.Windows.Forms.PictureBox();
            this.picBoxDegisiklik = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferlerDatgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYuklenme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDegisiklik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold);
            this.lblUrunAd.Location = new System.Drawing.Point(12, 9);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(103, 37);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "label1";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 233);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 5;
            series1.LabelToolTip = "#VAL{C2}";
            series1.Legend = "Legend1";
            series1.Name = "line";
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round;
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 5;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(781, 300);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quantity.Location = new System.Drawing.Point(12, 46);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(49, 16);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "--- adet";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold);
            this.itemPriceLabel.Location = new System.Drawing.Point(323, 123);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(103, 37);
            this.itemPriceLabel.TabIndex = 3;
            this.itemPriceLabel.Text = "label2";
            this.itemPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityTextBox.Location = new System.Drawing.Point(19, 90);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(348, 35);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.Text = "0";
            // 
            // valTextBox
            // 
            this.valTextBox.Enabled = false;
            this.valTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valTextBox.Location = new System.Drawing.Point(413, 89);
            this.valTextBox.Name = "valTextBox";
            this.valTextBox.Size = new System.Drawing.Size(380, 35);
            this.valTextBox.TabIndex = 6;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyButton.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyButton.Location = new System.Drawing.Point(264, 163);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(498, 61);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "AL";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // transferlerDatgrid
            // 
            this.transferlerDatgrid.AllowDrop = true;
            this.transferlerDatgrid.AllowUserToAddRows = false;
            this.transferlerDatgrid.AllowUserToDeleteRows = false;
            this.transferlerDatgrid.AllowUserToOrderColumns = true;
            this.transferlerDatgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transferlerDatgrid.BackgroundColor = System.Drawing.Color.White;
            this.transferlerDatgrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transferlerDatgrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.transferlerDatgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transferlerDatgrid.GridColor = System.Drawing.Color.Plum;
            this.transferlerDatgrid.Location = new System.Drawing.Point(12, 563);
            this.transferlerDatgrid.MultiSelect = false;
            this.transferlerDatgrid.Name = "transferlerDatgrid";
            this.transferlerDatgrid.ReadOnly = true;
            this.transferlerDatgrid.RowHeadersWidth = 51;
            this.transferlerDatgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transferlerDatgrid.ShowEditingIcon = false;
            this.transferlerDatgrid.Size = new System.Drawing.Size(781, 172);
            this.transferlerDatgrid.TabIndex = 10;
            // 
            // lblSonEmirler
            // 
            this.lblSonEmirler.AutoSize = true;
            this.lblSonEmirler.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblSonEmirler.Location = new System.Drawing.Point(12, 532);
            this.lblSonEmirler.Name = "lblSonEmirler";
            this.lblSonEmirler.Size = new System.Drawing.Size(163, 31);
            this.lblSonEmirler.TabIndex = 11;
            this.lblSonEmirler.Text = "Son Emirler:";
            this.lblSonEmirler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderProcces
            // 
            this.orderProcces.DoWork += new System.ComponentModel.DoWorkEventHandler(this.orderProcces_DoWork);
            this.orderProcces.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.orderProcces_RunWorkerCompleted);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(320, 232);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(150, 13);
            this.lblMesaj.TabIndex = 13;
            this.lblMesaj.Text = "Emir İşleniyor Lütfen Bekleyin..";
            this.lblMesaj.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Miktar:";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(410, 74);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(73, 13);
            this.secondLabel.TabIndex = 15;
            this.secondLabel.Text = "Toplam Tutar:";
            // 
            // btnIstek
            // 
            this.btnIstek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIstek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIstek.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstek.ForeColor = System.Drawing.Color.White;
            this.btnIstek.Location = new System.Drawing.Point(19, 163);
            this.btnIstek.Name = "btnIstek";
            this.btnIstek.Size = new System.Drawing.Size(200, 61);
            this.btnIstek.TabIndex = 16;
            this.btnIstek.Text = "İstek";
            this.btnIstek.UseVisualStyleBackColor = false;
            this.btnIstek.Click += new System.EventHandler(this.btnIstek_Click);
            // 
            // picBoxYuklenme
            // 
            this.picBoxYuklenme.Enabled = false;
            this.picBoxYuklenme.Image = global::bitlancer.Properties.Resources.ezgif_2_6d0b072c3d3f;
            this.picBoxYuklenme.Location = new System.Drawing.Point(305, 9);
            this.picBoxYuklenme.Name = "picBoxYuklenme";
            this.picBoxYuklenme.Size = new System.Drawing.Size(165, 58);
            this.picBoxYuklenme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxYuklenme.TabIndex = 12;
            this.picBoxYuklenme.TabStop = false;
            this.picBoxYuklenme.Visible = false;
            // 
            // picBoxDegisiklik
            // 
            this.picBoxDegisiklik.Image = global::bitlancer.Properties.Resources.reverse_pngrepo_com;
            this.picBoxDegisiklik.Location = new System.Drawing.Point(373, 90);
            this.picBoxDegisiklik.Name = "picBoxDegisiklik";
            this.picBoxDegisiklik.Size = new System.Drawing.Size(34, 34);
            this.picBoxDegisiklik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDegisiklik.TabIndex = 8;
            this.picBoxDegisiklik.TabStop = false;
            this.picBoxDegisiklik.Click += new System.EventHandler(this.picBoxDegisiklik_Click);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 747);
            this.Controls.Add(this.btnIstek);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.picBoxYuklenme);
            this.Controls.Add(this.lblSonEmirler);
            this.Controls.Add(this.transferlerDatgrid);
            this.Controls.Add(this.picBoxDegisiklik);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.valTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lblUrunAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferlerDatgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYuklenme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDegisiklik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox valTextBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.PictureBox picBoxDegisiklik;
        private System.Windows.Forms.DataGridView transferlerDatgrid;
        private System.Windows.Forms.Label lblSonEmirler;
        private System.ComponentModel.BackgroundWorker orderProcces;
        private System.Windows.Forms.PictureBox picBoxYuklenme;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Button btnIstek;
    }
}