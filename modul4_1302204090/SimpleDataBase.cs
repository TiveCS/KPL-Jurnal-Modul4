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
			storedData = new List<T>();
			inputDate = new List<DateTime>();
		}

		public void AddNewData(T data)
		{
			storedData.Add(data);
			inputDate.Add(DateTime.Now);
		}

		public void PrintAllData()
		{
			for (int i = 0; i < storedData.Count; i++)
			{
				T data = storedData[i];
				DateTime dateTime = inputDate[i];

				Console.WriteLine("Data " + (i + 1) +  " berisi: " + data + ", yang disimpan pada waktu " + dateTime);
			}
		}

	}
}
