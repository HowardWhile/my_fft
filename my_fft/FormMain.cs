using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace my_fft
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // --------------------------------------------
            // init chart_signal style
            // --------------------------------------------
            var chart_area = this.chart_signal.ChartAreas[0];
            chart_area.ShadowOffset = 3; 
            chart_area.AxisX.MajorGrid.Enabled = false;
            chart_area.AxisX.LabelStyle.Enabled = false;
            chart_area.AxisX.MajorTickMark.LineWidth = 3; 
            chart_area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;            
            chart_area.AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            chart_area.AxisY.MajorGrid.LineWidth = 3;
            chart_area.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;
            // --------------------------------------------

            // --------------------------------------------

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.timer_display.Enabled = true;
            if( false == this.bg_fake_data.IsBusy )            
                this.bg_fake_data.RunWorkerAsync();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.timer_display.Enabled = false;
            this.bg_fake_data.CancelAsync();
        }

        private void bg_fake_data_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer_display_Tick(object sender, EventArgs e)
        {

        }
    }
}
