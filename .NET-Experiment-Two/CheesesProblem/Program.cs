using System;

namespace CheesesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 81; i >0;i-- )
            {
                if (i / 9 % 3 == i % 9 % 3) //以81-73为例，前半截i/9一直是8，后半截i%9是0,8-1
                    continue;
                Console.Out.WriteLine("A = {0}, B = {1}\n", i / 9 + 1, i % 9 + 1);
            }
        }
    }
}
