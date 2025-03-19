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
            Console.WriteLine($"Data: {storedData[i]} , Date: {inputDates[i]} ");
        }
    }
}
    
class PemrosesData
{

    public void DapatkanNilaiTerbesar<T>(T d1, T d2, T d3)
    {
        dynamic temp1 = (dynamic)d1;
        dynamic temp2 = (dynamic)d2;
        dynamic temp3 = (dynamic)d3;

        if (temp1 > temp2 && temp2 > temp3)
        {
            Console.WriteLine("Data 1 (" + temp1 + ") merupakan nilai terbesar");
        }
        else if (temp2 > temp1 && temp2 > temp3)
        {
            Console.WriteLine("Data 2 (" + temp2 + ") merupakan nilai terbesar");
        }
        else
        {
            Console.WriteLine("Data 3 (" + temp3 + ") merupakan nilai terbesar");
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
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar(10, 30, 22);
    }
}