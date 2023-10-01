//#define SHOOTER
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal class Program
	{
		static readonly string delimiter = "\n----------------------------------------------------\n";
		static void Main(string[] args)
		{
#if SHOOTER
			int COMMAND;
			Console.WriteLine("Нажмите 'W', 'A' 'S' 'D' для движения");
			Console.WriteLine("Нажмите 'Space' для прыжка");
			Console.WriteLine("Нажмите 'F' чтобы открыть огонь");
			Console.WriteLine("Esc - выход");
			Console.WriteLine(delimiter);
			do
			{
				COMMAND = Console.ReadKey().KeyChar;
				switch (COMMAND)
				{
					case 'w': case 'W': Console.WriteLine("Вперед"); break;
					case 'a': case 'A': Console.WriteLine("Влево"); break;
					case 's': case 'S': Console.WriteLine("Назад"); break;
					case 'd': case 'D': Console.WriteLine("Вправо"); break;
					case ' ': Console.WriteLine("Прыжок"); break;
					case 'f': case 'F': Console.WriteLine("Огонь"); break;
					default: Console.WriteLine("!Wrong command!"); break;
				}

			} while (COMMAND != 27); 
#endif
			////////////////////////////////////// GEOMETRY #1 ///////////////////////////////////////////
			Console.WriteLine("Geometry #0:");
			Console.Write("Введите размер фигуры:\t");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Geometry #1:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Geometry #2:");
			for (int i = n; i > 0; i--)
			{
				for (int j = i; j > 0; j--)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Geometry #3:");
			for (int i = 0; i < n; i++)
			{
				for (int k = 0; k < i; k++) Console.Write(" ");
				for (int j = n; j > i; j--) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine("Geometry #4:");
			for (int i = 0; i < 5; i++)
			{
				for (int k = n; k > i; k--) Console.Write(" ");
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Geometry #5");
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
				for (int j = 0; j < i * 2; j++) Console.Write(" "); Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
				for (int j = 0; j < (n - 1 - i) * 2; j++) Console.Write(" "); Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine("CHESS");
			Console.Write("Введите размер шахматной доски: ");
			int n_chess = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int s = 0; s < 5; s++)
				{
					for (int j = 0; j < n; j++)
					{
						if (i % 2 == j % 2)
						{
							for (int k = 0; k < 5; k++) Console.Write("* ");
						}
						else
						{
							for (int l = 0; l < 5; l++)
							{
								Console.Write("  ");
							}
						}
					}
						int j = 0;
					Console.WriteLine();
				}
			}
		}
	}
}
