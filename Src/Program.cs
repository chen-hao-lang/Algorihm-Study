using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("请输入姓名：");
        //string name = Console.ReadLine();

        //Console.Write("请输入学号");
        //int id = int.Parse(Console.ReadLine());

        //Console.WriteLine($"姓名：{name},学号：{id}");
        Console.WriteLine("Hello wrold");
    }

    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        int s0 = 0, s1 = 0;
        int maxS1=0;
        int n = customers.Length;

        for(int i =0;i<n;i++)
        {
            s0 += grumpy[i]==0? customers[i] :0;
            s1 += grumpy[i]==1? customers[i] :0;

            int left = i - minutes +1;
            if(left<0) continue;

            maxS1 = System.Math.Max(maxS1,s1);
            s1 -= grumpy[i]==1?customers[left] :0;
        }
        return s0 + maxS1;
    }
}