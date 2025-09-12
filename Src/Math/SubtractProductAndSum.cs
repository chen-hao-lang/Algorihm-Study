using System.Numerics;

namespace Alogorihm.Math
{
    /// <summary>
    ///  整数的各位积和之差
    /// </summary>
    class SubtractProductAndSum
    {
        public int Slove(int n)
        {
            int sum = 0, product = 1;
            while (n > 0)
            {
                //计算各位数字之和
                sum += n % 10;
                //计算各位数字之积
                product *= n % 10;
                n /= 10;
            }
            //计算两者之差
            return product - sum;
        }
    }
}