using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Employee : Person
    {
        //- SalaryOfHour (saatbaşı qazandığı maaş)
        //- WorkingHour(30 gün ərzində neçə saat işlədiyi)
        //- CalculateSalary() - Ümumi maaşı hesablayan method.
        //memberləri olur.

        
        public double SalaryOfHour { get; set; }
        public int WorkingHour { get; set; }
        public Employee(double SalaryOfHour, int WorkingHour):base()
        {
            if (SalaryOfHour>=8)
            {
            this.SalaryOfHour = SalaryOfHour;

            }
            if (true)
            {

            }
            this.WorkingHour = WorkingHour;
        }

        public Employee()
        {
        }

        public void CalculateSalary(double SalaryOfHour , int WorkingHour, int v)
        {
            int TotalSalary = SalaryOfHour * WorkingHour;

        }
    }
}
