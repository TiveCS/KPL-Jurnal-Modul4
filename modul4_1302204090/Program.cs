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
			
			// Demo SimpleDataBase
			SimpleDataBase<long> simpleDataBase = new SimpleDataBase<long>();

			simpleDataBase.AddNewData(13);
			simpleDataBase.AddNewData(02);
			simpleDataBase.AddNewData(20);

			simpleDataBase.PrintAllData();

			// Demo Penjumlahan 3 angka
			long x = 13;
			long y = 02;
			long z = 20;

			Penjumlahan<long> penjumlahan = new Penjumlahan<long>();
			long result = penjumlahan.JumlahTigaAngka(x, y, z);

			Console.WriteLine(result);
		}
	}
}
