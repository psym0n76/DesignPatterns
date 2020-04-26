using System;

namespace Observer
{
    public class Chart : IObserver
    {

        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got update " + _dataSource.Value);
        }
    }
}