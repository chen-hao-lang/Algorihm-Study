namespace Alogorihm.Math
{
    /// <summary>
    /// 最小偶倍数
    /// </summary>
    public class SmallestEvenMultiple
    {
        public int Slove(int n)
        {
            return n % 2 == 0 ? n : n * 2;
        }
    }
}