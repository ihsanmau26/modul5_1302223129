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

    public static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 22));
    }
}