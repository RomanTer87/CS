using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static readonly string delimiter = "\n---------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			FillRand(arr);
			Print(arr);
			
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine(delimiter);

			Console.WriteLine($"Сумма элементов массива: { arr.Sum()}");
			Console.WriteLine($"Среднее арифметическое элементов массива: { arr.Average()}");
			Console.WriteLine($"Наименьший элемент в массиве: {arr.Min()}");
			Console.WriteLine($"Наибольший элемент в массиве: {arr.Max()}");
			Console.WriteLine(delimiter);

			double[] d_arr = new double[n];
			FillRand(d_arr);
			Print(d_arr);
			Console.WriteLine($"Сумма элементов массива: {d_arr.Sum()}");
			Console.WriteLine($"Среднее арифметическое элементов массива: {d_arr.Average()}");
			Console.WriteLine($"Наименьший элемент в массиве: {d_arr.Min()}");
			Console.WriteLine($"Наибольший элемент в массиве: {d_arr.Max()}");
			Console.WriteLine(delimiter);

			//////////////////////////////////////////////////////////////////////////

			Console.WriteLine("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			int[,] i_arr_2 = new int[rows, cols];
			FillRand(i_arr_2);
			Print(i_arr_2);
			
			Console.WriteLine(i_arr_2.GetType());
			Console.WriteLine(delimiter);

			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
			Console.WriteLine($"Наименьший элемент в массиве: {i_arr_2.Cast<int>().Min()}");
			Console.WriteLine($"Наибольший элемент в массиве: {i_arr_2.Cast<int>().Max()}");
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////

			int[][] jagged_arr = new int[][]
			{
				new int[]{3,5,8,13,21},
				new int[]{34,55,89},
				new int[]{144,233,377,510},
				arr
			};
			for (int i = 0; i < jagged_arr.Length; i++)
			{
				for (int j = 0; j < jagged_arr[i].Length; j++)
				{
					Console.Write(jagged_arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			int[][,] jagged_arr_2 = new int[][,]
			{
			i_arr_2,
			new int[,]
			{
				{256,384,512,768 },
				{1024,2048,3072,4096 }
			}
			};
		}
		public static void FillRand(int[] arr)
		{
			Random rand = new Random(0);    //Создаем объект класса 'Random' для того чтобы генерировать случайные числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100,200);
			}
		}

		public static void FillRand(double[] arr)
		{
			Random rand = new Random(0);    //Создаем объект класса 'Random' для того чтобы генерировать случайные числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = (double)rand.Next(100,200)/10;
			}
		}
		public static void FillRand(int[,]arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rand.Next(100);
				}
			}
		}

		public static void Print<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
		}
		public static int Sum(int[] arr)
		{
		int sum = 0;
			for(int i=0; i<arr.Length; i++) 
			{
			sum+= arr[i];
			}
			return sum;
		}

		public static double Avg(int[] arr)
		{
			return (double)Sum(arr)/arr.Length;
		}

		public static double MinValueIn(int[] arr)
		{
			double min = arr[0];
			for(int i=0; i<arr.Length;i++) if (arr[i] < min) min = arr[i];
			return min;
		}

		public static double MaxValueIn(int[] arr)
		{
			double max = arr[0];
			for (int i = 0; i < arr.Length; i++) if (arr[i] > max) max = arr[i];
			return max;
		}
		public static void Print<T>(T[,]arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
