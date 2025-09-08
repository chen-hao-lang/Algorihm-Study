namespace Alogorihm
{
    /// <summary>
    /// 找到最近的人
    /// </summary>
    class FindClosest
    {
        public int Slove(int x, int y, int z)
        {
            //取x到z的距离的绝对值
            int a = Math.Abs(x - z);
            //取y到z的距离的绝对值
            int b = Math.Abs(y - z);
            //比较二者的绝对值距离大小
            return a == b ? 0 : a > b ? 2 : 1;
        }
    }
}