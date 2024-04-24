using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace countdate.Models
{
    public class DateCalculator
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

      public void Calculate(DateTime startDate, DateTime endDate)
        {
            // Tính toán số năm
            Years = endDate.Year - startDate.Year;

            // Tính toán số tháng
            Months = endDate.Month - startDate.Month;
            if (Months < 0)
            {
                Years--;
                Months += 12;
            }

            // Tính toán số ngày
            DateTime tempEndDate = startDate.AddMonths(Months).AddYears(Years);
            Days = (endDate - tempEndDate).Days;
        }
    }


}