using System;

namespace Amazon_PackagingAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = new int[] { 1, 1,1, 1 };
            Console.WriteLine(packagingMine(arr));
        }

		static int packagingMine(int[] arr)
		{
			int[] freq = new int[190000];
			int max = 0;
			for (int k = 0; k < arr.Length; ++k)
			{
				freq[arr[k]]++;
				max = Math.Max(max, arr[k]);
			}
			int i = 1;
			int j = 0;
			while (i <= max)
			{
				if (freq[i] > 0 && j < i)
				{
					arr[j++] = j;
				}
				freq[i]--;
				if (freq[i] < 1)
				{
					i++;
				}
			}
			return arr[j - 1];
		}
	}
}
