using System.ComponentModel;

namespace Alogorihm.Math
{
    /// <summary>
    /// 各位相加
    /// </summary>
    class AddDigits
    {
        public int Slove(int num)
        {
            // string str = num.ToString();
            // char[] chars = str.ToCharArray();
            // int sum = 0;

            // foreach (var item in chars)
            // {
            //     sum += int.Parse(item.ToString());
            // }

            // return sum;

            while (num >= 10)
            {
                int sum = 0;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                num = sum;
            }
            return num;
        }
    }
}