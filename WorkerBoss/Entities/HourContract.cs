using System;

namespace WorkerBoss.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHouer { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHouer, int hour)
        {
            Date = date;
            ValuePerHouer = valuePerHouer;
            Hours = hour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHouer;
        }
    }
}
