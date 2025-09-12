using System;
using System.Globalization;

namespace  Array
{   
    ///好三元数
    class CountGoodTriplets
    {
        public int Slove(int[] arr,int a,int b,int c)
        {
            int res =0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}