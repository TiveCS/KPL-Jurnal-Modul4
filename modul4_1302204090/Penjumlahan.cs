using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204090
{
	internal class Penjumlahan<T> where T : IComparable<T>
	{

		public T JumlahTigaAngka(T x, T y, T z)
		{
			dynamic temp = x;

			temp += y;
			temp += z;

			return temp;
		}

	}
}
