namespace Cronos
{
    partial class frmcharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.charts = new System.Windows.Forms.Panel();
            this.lblClientesVencimientos = new System.Windows.Forms.Label();
            this.dgvMembresiaProxAven = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresiaProxAven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(74, 450);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(369, 277);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // charts
            // 
            this.charts.BackColor = System.Drawing.Color.White;
            this.charts.Controls.Add(this.iconPictureBox1);
            this.charts.Controls.Add(this.dataGridView1);
            this.charts.Controls.Add(this.lblClientesVencimientos);
            this.charts.Controls.Add(this.dgvMembresiaProxAven);
            this.charts.Controls.Add(this.chart1);
            this.charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charts.Location = new System.Drawing.Point(0, 0);
            this.charts.Name = "charts";
            this.charts.Size = new System.Drawing.Size(941, 764);
            this.charts.TabIndex = 4;
            this.charts.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblClientesVencimientos
            // 
            this.lblClientesVencimientos.AutoSize = true;
            this.lblClientesVencimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesVencimientos.Location = new System.Drawing.Point(49, 26);
            this.lblClientesVencimientos.Name = "lblClientesVencimientos";
            this.lblClientesVencimientos.Size = new System.Drawing.Size(459, 25);
            this.lblClientesVencimientos.TabIndex = 2;
            this.lblClientesVencimientos.Text = " Clientes con membresía próxima a vencer";
            // 
            // dgvMembresiaProxAven
            // 
            this.dgvMembresiaProxAven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembresiaProxAven.Location = new System.Drawing.Point(64, 64);
            this.dgvMembresiaProxAven.Name = "dgvMembresiaProxAven";
            this.dgvMembresiaProxAven.Size = new System.Drawing.Size(836, 125);
            this.dgvMembresiaProxAven.TabIndex = 1;
            this.dgvMembresiaProxAven.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMembresiaProxAven_CellFormatting);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 125);
            this.dataGridView1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 46;
            this.iconPictureBox1.Location = new System.Drawing.Point(514, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 46);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmcharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 764);
            this.Controls.Add(this.charts);
            this.Name = "frmcharts";
            this.Text = "frmcharts";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.charts.ResumeLayout(false);
            this.charts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresiaProxAven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Panel charts;
        private System.Windows.Forms.Label lblClientesVencimientos;
        private System.Windows.Forms.DataGridView dgvMembresiaProxAven;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}