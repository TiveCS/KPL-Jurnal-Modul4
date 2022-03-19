using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{
			long x = 13;
			long y = 02;
			long z = 20;

			Penjumlahan<long> penjumlahan = new Penjumlahan<long>();
			long result = penjumlahan.JumlahTigaAngka(x, y, z);

			Console.WriteLine(result);
		}
	}
}
