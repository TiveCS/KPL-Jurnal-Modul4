using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204090
{
	internal class SimpleDataBase<T>
	{

		private List<T> storedData;
		private List<DateTime> inputDate;

		public SimpleDataBase()
		{
			// Membuat instance baru dari storedData dan inputDate
			storedData = new List<T>();
			inputDate = new List<DateTime>();
		}

		public void AddNewData(T data)
		{
			// Tambahkan parameter data ke storedData
			storedData.Add(data);

			// Tambahkan tanggal dan waktu saat ini ke inputDate
			inputDate.Add(DateTime.Now);
		}

		public void PrintAllData()
		{
			// Loop tiap elemen dari storedData
			for (int i = 0; i < storedData.Count; i++)
			{
				// Ambil data dari storedData
				T data = storedData[i];

				// Ambil tanggal dan waktu dari inputData
				DateTime dateTime = inputDate[i];

				// Tampilkan pesan berisi data dan tanggal & waktu input
				Console.WriteLine("Data " + (i + 1) +  " berisi: " + data + ", yang disimpan pada waktu " + dateTime);
			}
		}

	}
}
