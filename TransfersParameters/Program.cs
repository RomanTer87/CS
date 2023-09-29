using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransfersParameters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a;
			int b;
			Input(out a,out b);	
			Console.WriteLine($"{a}\t{b}");
			Exchange(ref a,ref b);
			Console.WriteLine($"{a}\t{b}");
		}
		static void Input(out int a,out int b)
		{
			Console.Write("введите первое число"); a = Convert.ToInt32(Console.ReadLine());
			Console.Write("введите второе число"); b = Convert.ToInt32(Console.ReadLine());

		}
	static void Exchange(ref int a, ref int b)
		{
			int buffer = a;
			a = b;
			b = buffer;
		}
	}
}
