using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace my_fft.model
{
    class FourierTool
    {
        public class Result
        {
            public Result(int i_sample_len)
            {
                Array.Resize(ref x_hz, i_sample_len);
                Array.Resize(ref y_magnitude, i_sample_len);
            }

            // 頻域
            public double[] x_hz; // 頻率
            public double[] y_magnitude; // 強度

            public double hz_per_sample; // x軸每間隔差多少hz
        }

        public Result FFT(double[] iWave, int iSampleRate = 1000)
        {
            if (iWave.Length < iSampleRate)
            {
                return new Result(0);
            }
            // ------------------------------------
            // 複數的實部是 訊號源
            // ------------------------------------
            Complex[] samples = new System.Numerics.Complex[iWave.Length];
            for (int i = 0; i < samples.Length; i++)
                samples[i] = new System.Numerics.Complex(iWave[i], 0.0);
            // ------------------------------------
            // 計算結果會覆寫回 samples
            // ------------------------------------
            // FFT
            MathNet.Numerics.IntegralTransforms.Fourier.Forward(samples, FourierOptions.NoScaling);
            //MathNet.Numerics.IntegralTransforms.Fourier.Forward(samples, FourierOptions.Matlab);
            // ------------------------------------
            // 計算sample在頻域時離散的間隔是多少hz
            // ------------------------------------
            double number_sample = iWave.Length;
            double hz_per_sample = (double)iSampleRate / number_sample;
            // ------------------------------------
            // 初始化要回傳的FFT資料結構
            // ------------------------------------
            // Result r_value = new Result((int)number_sample);
            // 取樣定理描述 可以忽略高於採樣頻率一半的頻率成分 因有混疊發生
            double number_sample2 = number_sample / 2.0;
            Result r_value = new Result((int)number_sample2);
            r_value.hz_per_sample = hz_per_sample;
            // ------------------------------------
            for (int i = 0; i < r_value.x_hz.Length; i++)
            {
                r_value.x_hz[i] = hz_per_sample * i;

                // http://www.csie.ntnu.edu.tw/~u91029/Wave.html 
                // Complex Number -> magnitude 
                //r_value.y_magnitude[i] = samples[i].Magnitude;

                // 將強度正規化 Normalization: magnitude / (number_sample / 2.0)  
                r_value.y_magnitude[i] = samples[i].Magnitude / number_sample2;
            }
            // ------------------------------------
            r_value.y_magnitude[0] = 0.0;
            return r_value;
        }
    }
}
