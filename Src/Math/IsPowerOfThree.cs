namespace Alogorihm.Math
{
    class IsPowerOfThree
    {
        public bool Slove(int n)
        {
            while (n != 0 && n % 3 == 0)
            {
                n /= 3;
            } 
            
            return n == 1;  
        }
    }
}