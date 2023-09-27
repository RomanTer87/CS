//#define SHOOTER
using System;
using System.Collections.Generic;
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


		}
	}
}
