using System;

namespace CSharpHomework
{
    class Program
    {
		public static int IsPrime(int x)
		{
			for (int i = 2; i * i <= x; i++)
				if (x % i == 0)
					return 0;
			return 1;
		}

		static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 2; i*i <= n; i++)
            {
				if (n % i == 0 && IsPrime(i) == 1)
					Console.WriteLine(i);
            }
        }		
	}
}
