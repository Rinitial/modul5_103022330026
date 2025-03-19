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
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar(10, 30, 22);
    }
}
