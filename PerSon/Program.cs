using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.name = "Anar";
            per.surname = "Qandayev";
            per.age = 19;
            Employee emp = new Employee();
            //emp.dayOfHour = 9;
            //emp.weekOfWorkDayCount = 4;
            //emp.dailyEarnings = 5;

            Console.WriteLine("Ayliq maash " + emp.CalculateSalary(7, 8, 8) + " azn-dir");
            Student st = new Student();
            //st.IQRank = 70;
            //st.LanguageRank = 60;
            //st.ExamResult(68, 79);
            Console.WriteLine( $"sizin imtahan neticeniz {st.ExamResult(70, 60)}");



        }
    }
}
