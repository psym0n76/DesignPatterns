using System;

namespace Observer
{
    public class Spreadsheet : IObserver
    {
        private readonly DataSource _dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet updating " + _dataSource.Value);
        }
    }
}