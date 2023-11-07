using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"bool: {sizeof(bool)}, values: {true} or {false}");
			Console.WriteLine($"char: {sizeof(char)}"); //unicode
														//short, ushort;
														//int, uint;
			Console.WriteLine($"short: {sizeof(short)} Байт памяти, диапазон значений: {short.MinValue} ... {short.MaxValue}");
			Console.WriteLine($"short: {sizeof(ushort)} Байт памяти, диапазон значений: {ushort.MinValue} ... {ushort.MaxValue}");

			Console.WriteLine($"float: {sizeof(float)} Байт памяти, диапазон значений: {float.MinValue} ... {float.MaxValue}");
			Console.WriteLine($"double: {sizeof(double)} Байт памяти, диапазон значений: {double.MinValue} ... {double.MaxValue}");
			Console.WriteLine($"decimal: {sizeof(decimal)} Байт памяти, диапазон значений: {decimal.MinValue} ... {decimal.MaxValue}");

			Console.WriteLine('+'.GetType());
			Console.WriteLine(5.GetType());
			Console.WriteLine(5.5.GetType());
			Console.WriteLine(5.5f.GetType());
			Console.WriteLine(5.5m.GetType());	//m - Money

			Convert
		}
	}
}
