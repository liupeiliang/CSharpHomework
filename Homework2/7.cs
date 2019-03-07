using System;

namespace CSharpHomework
{
    class Program
    {
		const int INF = 0x3f3f3f3f;

		static void Main(string[] args)
        {
			//Console.WriteLine(INF);
            int n = Int32.Parse(Console.ReadLine());
			int sum = 0, mx = -INF, mi = INF;
			for (int i = 0; i < n; i++)
			{
				int x = Int32.Parse(Console.ReadLine());
				sum += x;
				if (x > mx) mx = x;
				if (x < mi) mi = x;
			}
			Console.WriteLine("max number is " + mx);
			Console.WriteLine("min number is " + mi);
			Console.WriteLine("sum is " + mx);
			Console.WriteLine("average is " + (double)sum / n);
		}
	}
}
