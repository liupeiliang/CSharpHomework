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
			int[] np = new int[n + 1];
			int[] prime = new int[n + 1];
			np[1] = 1;
			int sum = 0;
			for(int i = 2; i <= n; i++)
			{
				if (np[i] == 0)
				{
					prime[++sum] = i;
					for (int j = i + i; j <= n; j += i)
						np[j] = 1;
				}
			}
			Console.WriteLine(sum + " numbers");
			for (int i = 1; i <= sum; i++)
				Console.WriteLine(prime[i]);
		}
	}
}
