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
