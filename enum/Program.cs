using System;    
namespace example_enum 
{    
    class Program {    
        public enum DayofWeek {    
            Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday    
        }    
        static void Main(string[] args) {    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Sunday, DayofWeek.Sunday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Monday, DayofWeek.Monday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Tuesday, DayofWeek.Tuesday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Wednesday, DayofWeek.Wednesday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Thursday, DayofWeek.Thursday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Friday, DayofWeek.Friday);    
            Console.WriteLine("Day of week {0} {1}", (int) DayofWeek.Saturday, DayofWeek.Saturday);    
            Console.ReadLine();    
        }    
    }    
}  