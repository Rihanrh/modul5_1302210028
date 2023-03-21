// See https://aka.ms/new-console-template for more information

class SimpleDataBase<T>
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
        for (int i = 0; i<this.inputDates.Count;i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " +
                this.storedData[i] + ", yang disimpan pada waktu UTC: " +
                this.inputDates[i]);
        }
    }
}


namespace modul5_1302210028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NIM: 1302210028 = 8
            //tipe data input int
            Penjumlahan angka = new Penjumlahan();
            angka.JumlahTigaAngka<int>(13, 21, 28);

            Console.WriteLine();

            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(21);
            data.AddNewData(28);

            data.PrintAllData();
        }
    }
}
