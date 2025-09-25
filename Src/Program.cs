using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入姓名：");
        string name = Console.ReadLine();

        Console.Write("请输入学号");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine($"姓名：{name},学号：{id}");
    }
}