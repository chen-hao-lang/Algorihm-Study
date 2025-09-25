namespace Alogorihm.Math
{
    /// <summary>
    ///  判断是否为2的幂
    /// </summary>
    class IsPowerOfTwo
    {
        public bool Slove(int n)
        {
            // 2的幂的二进制表示中只有一个1，其余全是0

            //2的二进制表示：  0000 1000
            //2-1的二进制表示：0000 0111
            //两者按位与的结果：0000 0000
            return n > 0 && (n & (n - 1)) == 0;
        }

        public bool Slove1(int n)
        {
            while (n != 0 && n % 2 == 0)
            {
                n /= 2;
            }   
            
            return n == 1;
        }
    }
}