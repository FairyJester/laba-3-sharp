using System;

namespace laba3_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string DayOfWeekS = "unknown";
            string Time = "unknown";
            Console.WriteLine("введите день недели");
            int DayOfWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите целый час от 0 до 23");
            int Hour = Convert.ToInt32(Console.ReadLine());

            switch (DayOfWeek)
            {
                case 1:
                    DayOfWeekS = Convert.ToString(days_of_week.Monday);
                    break;
                case 2:
                    DayOfWeekS = Convert.ToString(days_of_week.Tuesday);
                    break;
                case 3:
                    DayOfWeekS = Convert.ToString(days_of_week.Wednesday);
                    break;
                case 4:
                    DayOfWeekS = Convert.ToString(days_of_week.Thursday);
                    break;
                case 5:
                    DayOfWeekS = Convert.ToString(days_of_week.Friday);
                    break;
                case 6:
                    DayOfWeekS = Convert.ToString(days_of_week.Saturday);
                    break;
                case 7:
                    DayOfWeekS = Convert.ToString(days_of_week.Sunday);
                    break;
                default:
                    Console.WriteLine("Дней недели всего 7");
                    break;
            }
            if (Hour >= 7 && Hour <= 12)
            {
                Time = Convert.ToString(DayTime.Morning);
            }
            else if (Hour >= 13 && Hour <= 18)
            {
                Time = Convert.ToString(DayTime.Afternoon);
            }
            else if (Hour >= 19 && Hour <= 23)
            {
                Time = Convert.ToString(DayTime.Evening);
            }
            else if (Hour >= 0 && Hour <= 6)
            {
                Time = Convert.ToString(DayTime.Night);
            }
            else
            {
                Console.WriteLine("В сутках 24 часа от 0 до 23");
            }
            Console.WriteLine($"Сейчас {DayOfWeekS}, {Time}");
        }
            enum days_of_week
            {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
            }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
    }

}
    

