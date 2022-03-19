using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204090
{
	internal class Penjumlahan<T> where T : IComparable<T>
	{

		// Mengembalikan hasil jumlah dari 3 angka 
		public T JumlahTigaAngka(T x, T y, T z)
		{
			// Deklarasi dynamic variabel dan berikan nilai awal dari variabel x
			dynamic temp = x;

			// Tambahkan variabel y ke temp
			temp += y;

			// Tambahkan variabel z ke temp
			temp += z;

			return temp;
		}

	}
}
