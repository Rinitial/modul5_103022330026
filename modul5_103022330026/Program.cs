using System;
class SimpleDataBase<T>
{
    public List<T> storedData;
    public List<DateTime> inputDates;

    public SimpleDataBase() 
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        DateTime currentTime = DateTime.Now;
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data: {storedData[i]} , Date: {inputDates[i]} " );
        }
    }

    
}
class program
{
    private static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();
    }
}
