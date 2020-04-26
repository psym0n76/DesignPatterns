using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dataSource = new DataSource();

            var sheet1 = new Spreadsheet(dataSource);
            var sheet2 = new Spreadsheet(dataSource);

            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.Value = 1;
            dataSource.Value = 2;

        }
    }
}
