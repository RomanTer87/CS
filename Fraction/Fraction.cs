using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{

		int denominator;
		public int Integer
		{
			get;
			set;
		}
		public int Numerator
		{
			get;
			set;
		}

		public int Denominator
		{
			get { return denominator; }
			set
			{
				if (value == 0) value = 1;
				denominator = value;
			}
		}
		//////////////////////////////////////////////////////CONSTRUCTORS/////////////////////////
		public Fraction()
		{
			Integer = Numerator = 0;
			Denominator = 1;
			Console.WriteLine($"DefaultConstructor:\t{this.GetHashCode()}");
		}
		public Fraction(int integer)
		{
			Integer = integer;
			Numerator = 0;
			Denominator = 1;
			Console.WriteLine($"1ArgConstructor:\t{this.GetHashCode()}");
		}
		public Fraction(int numerator, int denominator)
		{
			Integer = 0;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine($"Constructor:\t\t{this.GetHashCode()}");
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			Console.WriteLine($"Constructor:\t\t{this.GetHashCode()}");
		}
		public Fraction(Fraction other)
		{
			this.Integer = other.Integer;
			this.Numerator= other.Numerator;
			this.Denominator= other.Denominator;
			Console.WriteLine($"CopyConstructor:\t{this.GetHashCode()}");
		}

		public Fraction(double value)
		{
			Fraction res = new Fraction();
			Integer = (int)value;
			double dop = ((double)value - (int)value) * 100;
			Numerator = (int)dop;
			Denominator = 100;
			Inverted();
		}
		//// OPERATORS////////////////
		public static Fraction operator *(Fraction left, Fraction right)
		{
			Fraction left_copy = new Fraction(left);
			Fraction right_copy = new Fraction(right);
			left_copy.toImproper();
			right_copy.toImproper();
			return new Fraction(left_copy.Numerator * right_copy.Numerator, left_copy.Denominator * right_copy.Denominator).toProper();
		}
		public static Fraction operator/(Fraction left, Fraction right)
		{
			return left * right.Inverted();
		}

		///////////////// METHODS ///////////////////
		public Fraction toProper()
		{
			Integer += Numerator / Denominator;
			Numerator %=Denominator;
			return this;
		}
		public Fraction toImproper()
		{
			Numerator += Integer * Denominator;
			Integer = 0;
			return this;
		}
		public Fraction Inverted()
		{
			Fraction inverted = new Fraction(this);
			inverted.toImproper();
			(inverted.Numerator, inverted.Denominator) = (inverted.Denominator, inverted.Numerator);
			return inverted;
		}
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator} / {Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}

		public override string ToString()
		{
			string output = "";
			if (Integer != 0) output += Integer.ToString();
			if (Numerator != 0)
			{
				if (Integer != 0) output += "(";
				output += $"{Numerator} / {Denominator}";
				if (Integer != 0) output += ")";
			}
			else if (Integer == 0) output = "0";
			return output;
		}
	}

}