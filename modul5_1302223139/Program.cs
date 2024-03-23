using System.Runtime.CompilerServices;

class program 
{
    public class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }
    }

    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>(); 
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < this.inputDates.Count; i++) {
                Console.WriteLine("Data " + (i+1) + " berisi: " + this.storedData[i] + ", yang disimpan pada waktu UTC:" + this.inputDates[i]);
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 22));

        SimpleDataBase<long> data = new SimpleDataBase<long>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}