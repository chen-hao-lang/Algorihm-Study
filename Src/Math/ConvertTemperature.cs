namespace Alogorihm.Math
{
    /// <summary>
    /// 温度转换
    /// </summary>
    public class ConvertTemperature
    {
        public double[] Slove(double celsius)
        {
            return new double[] { celsius + 273.15, celsius * 1.80 + 32.00 };
        }
    }
}