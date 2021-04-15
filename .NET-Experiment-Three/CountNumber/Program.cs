using System;

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,Cnt=0;
            
            Console.WriteLine("请输入一个数：");
            x=int.Parse(Console.ReadLine());
            for (; x != 0; x >>= 1)
            {
                if ((x & 1)==1)
                {
                    Cnt++;
                }
            }
            Console.WriteLine("{0}", Cnt);
        }
    }
}
