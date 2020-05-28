﻿namespace my_fft
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn_5hz = new System.Windows.Forms.RadioButton();
            this.rbtn_10hz = new System.Windows.Forms.RadioButton();
            this.rbtn_15hz = new System.Windows.Forms.RadioButton();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_fft = new ScottPlot.FormsPlot();
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.bg_fake_data = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chart_signal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart_signal
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_signal.ChartAreas.Add(chartArea6);
            this.chart_signal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart_signal.Legends.Add(legend6);
            this.chart_signal.Location = new System.Drawing.Point(4, 54);
            this.chart_signal.Margin = new System.Windows.Forms.Padding(4);
            this.chart_signal.Name = "chart_signal";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "src_wave";
            this.chart_signal.Series.Add(series6);
            this.chart_signal.Size = new System.Drawing.Size(555, 189);
            this.chart_signal.TabIndex = 0;
            this.chart_signal.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.rbtn_5hz, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtn_10hz, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtn_15hz, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_run, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_stop, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // rbtn_5hz
            // 
            this.rbtn_5hz.AutoSize = true;
            this.rbtn_5hz.Checked = true;
            this.rbtn_5hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_5hz.Location = new System.Drawing.Point(226, 4);
            this.rbtn_5hz.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_5hz.Name = "rbtn_5hz";
            this.rbtn_5hz.Size = new System.Drawing.Size(103, 34);
            this.rbtn_5hz.TabIndex = 0;
            this.rbtn_5hz.TabStop = true;
            this.rbtn_5hz.Text = "5 hz";
            this.rbtn_5hz.UseVisualStyleBackColor = true;
            // 
            // rbtn_10hz
            // 
            this.rbtn_10hz.AutoSize = true;
            this.rbtn_10hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_10hz.Location = new System.Drawing.Point(337, 4);
            this.rbtn_10hz.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_10hz.Name = "rbtn_10hz";
            this.rbtn_10hz.Size = new System.Drawing.Size(103, 34);
            this.rbtn_10hz.TabIndex = 1;
            this.rbtn_10hz.Text = "10 hz";
            this.rbtn_10hz.UseVisualStyleBackColor = true;
            // 
            // rbtn_15hz
            // 
            this.rbtn_15hz.AutoSize = true;
            this.rbtn_15hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_15hz.Location = new System.Drawing.Point(448, 4);
            this.rbtn_15hz.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_15hz.Name = "rbtn_15hz";
            this.rbtn_15hz.Size = new System.Drawing.Size(103, 34);
            this.rbtn_15hz.TabIndex = 2;
            this.rbtn_15hz.Text = "15 hz";
            this.rbtn_15hz.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_run.Location = new System.Drawing.Point(4, 4);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(103, 34);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stop.Location = new System.Drawing.Point(115, 4);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(103, 34);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.Controls.Add(this.chart_fft, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(557, 191);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // chart_fft
            // 
            this.chart_fft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_fft.Location = new System.Drawing.Point(7, 9);
            this.chart_fft.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.chart_fft.Name = "chart_fft";
            this.chart_fft.Size = new System.Drawing.Size(433, 173);
            this.chart_fft.TabIndex = 2;
            // 
            // timer_display
            // 
            this.timer_display.Interval = 30;
            this.timer_display.Tick += new System.EventHandler(this.timer_display_Tick);
            // 
            // bg_fake_data
            // 
            this.bg_fake_data.WorkerReportsProgress = true;
            this.bg_fake_data.WorkerSupportsCancellation = true;
            this.bg_fake_data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_fake_data_DoWork);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "My_FFT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_signal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtn_5hz;
        private System.Windows.Forms.RadioButton rbtn_10hz;
        private System.Windows.Forms.RadioButton rbtn_15hz;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ScottPlot.FormsPlot chart_fft;
        private System.Windows.Forms.Timer timer_display;
        private System.ComponentModel.BackgroundWorker bg_fake_data;
    }
}

