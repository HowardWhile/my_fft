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
        // ---------------------------------
        class signal_element
        {
            public signal_element()
            {
                this.time = 0.0;
                this.magnitude = 0.0;
            }

            public signal_element(double iTime, double iMagnitude)
            {
                this.time = iTime;
                this.magnitude = iMagnitude;
            }

            public double magnitude;
            public double time;
        }
        List<signal_element> src_wave = new List<signal_element>();
        // ---------------------------------
        ScottPlot.PlottableSignal plt_signal;
        ScottPlot.PlottableSignal plt_fft;
        // ---------------------------------
        // watch
        double last_time_mouse_on_chart_signal_s = -Double.MaxValue;
        private double clock_s()
        {
            TimeSpan  diff = DateTime.UtcNow.Subtract(System.Diagnostics.Process.GetCurrentProcess().StartTime.ToUniversalTime());
            return (double)diff.Ticks / TimeSpan.TicksPerSecond;
        }
        private double clock_ms()
        {
            TimeSpan diff = DateTime.UtcNow.Subtract(System.Diagnostics.Process.GetCurrentProcess().StartTime.ToUniversalTime());
            return (double)diff.Ticks / TimeSpan.TicksPerMillisecond;
        }
        // ---------------------------------

        private void FormMain_Load(object sender, EventArgs e)
        {
            // --------------------------------------------
            // init chart_signal style
            // --------------------------------------------
            double[] sin_swppe = ScottPlot.DataGen.SinSweep(10000, 10);
            this.plt_signal = this.chart_signal.plt.PlotSignal(sin_swppe, 1000);            
            this.chart_signal.Render();
            // -------------------------------------------
            sin_swppe = ScottPlot.DataGen.SinSweep(10000, 20);
            this.plt_fft = this.chart_fft.plt.PlotSignal(sin_swppe, 1000);
            this.chart_fft.Render();
            // --------------------------------------------
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.src_wave.Clear();
            this.timer_display.Enabled = true;
            if ( false == this.bg_fake_data.IsBusy )            
                this.bg_fake_data.RunWorkerAsync();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.timer_display.Enabled = false;
            this.bg_fake_data.CancelAsync();
        }

        private void bg_fake_data_DoWork(object sender, DoWorkEventArgs e)
        {
            // generate signal 
            // sample rate 1k Hz
            // frequency can be chose by radio button (5, 10, 15 hz)
            // The signal length will increase up to 30s
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            long last_time_gen_fake_data = watch.ElapsedMilliseconds;
            while (true)
            {
                // -----------------------------------
                long time_now_ms = watch.ElapsedMilliseconds;
                int ms = Convert.ToInt32(time_now_ms - last_time_gen_fake_data);
                last_time_gen_fake_data = time_now_ms;

                if (ms == 0)
                    continue;
                // -----------------------------------
                double time_now_s = (double)time_now_ms / 1000.0;
                // -----------------------------------
                double frequency = 1.0;
                if (this.rbtn_5hz.Checked)
                    frequency = 5.0;
                else if (this.rbtn_10hz.Checked)
                    frequency = 10.0;
                else if (this.rbtn_15hz.Checked)
                    frequency = 15.0;            
                // -----------------------------------
                List<signal_element> add_data = new List<signal_element>();
                for (int i = ms; i > 0; i--)
                {
                    double t = time_now_s - (i-1) * 0.001;
                    signal_element s_elem = new signal_element(t, this.signal_mag * Math.Cos(t * (2 * Math.PI) * frequency));
                    add_data.Add(s_elem);
                }
                // -----------------------------------
                lock (this.src_wave)
                {
                    this.src_wave.AddRange(add_data);
                    while(this.src_wave.Last().time - this.src_wave.First().time > 5.0) //
                    {
                        this.src_wave.RemoveAt(0);
                    }
                }
                // -----------------------------------
                System.Threading.Thread.Sleep(1); 
                // -----------------------------------
                if (this.bg_fake_data.CancellationPending)
                    break;
            }
        }

        private void timer_display_Tick(object sender, EventArgs e)
        {
            signal_element[] src_signal = new signal_element[1];
            lock (this.src_wave)
            {
                if (this.src_wave.Count > 0)
                {
                    src_signal = new signal_element[this.src_wave.Count];
                    this.src_wave.CopyTo(src_signal);
                }
            }

            if (src_signal.Length > 1)
            {
                double[] src_signal_y = new double[src_signal.Length];
                for (int i = 0; i < src_signal.Length; i++)
                {
                    src_signal_y[i] = src_signal[i].magnitude;
                }

                this.plt_signal.xOffset = src_signal[0].time;
                this.plt_signal.ys = src_signal_y;
                this.plt_signal.maxRenderIndex = src_signal_y.Length - 1;

                if( this.clock_s() - this.last_time_mouse_on_chart_signal_s > 5.0)
                    this.chart_signal.plt.AxisAuto(horizontalMargin: 0, verticalMargin: 0.5);
                //this.chart_signal.plt.

                this.chart_signal.Render();
            }
            

        }

        private double signal_mag = 1.0;
        private void tbar_signal_mag_Scroll(object sender, EventArgs e)
        {
            this.signal_mag = (double)this.tbar_signal_mag.Value / 10.0;
        }


        private void chart_signal_MouseMove(object sender, MouseEventArgs e)
        {
            //this.last_time_mouse_on_chart_signal_s = this.clock_s();

        }

        private void chart_signal_MouseDown(object sender, MouseEventArgs e)
        {
            //if
        }
    }
}
