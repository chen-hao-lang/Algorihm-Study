namespace Alogorihm.Math
{
    /// <summary>
    /// 数组异或操作
    /// </summary>
    public class XorOperation
    {
        public int Slove(int n, int start)
        {
            int res = 0;
            //先声明一个数组
            int[] arr = new int[n];
            //在对数组进行赋值
            for (int i = 0; i < n; i++)
            {
                arr[i] = start + 2 * i;

                //最后对数组进行异或操作
                res ^= arr[i];
            }
            return res;
        }
    }
}