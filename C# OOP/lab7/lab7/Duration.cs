using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minute { get; set; }
        
        public int Second { get; set; }

        public Duration(int _hourse,int _minute,int _seconds) { 

            Hours= _hourse;
            Minute= _minute;
            Second= _seconds;
        
        }
      

        public Duration (int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minute = (totalSeconds % 3600) / 60;
            Second = totalSeconds % 60;
        }

        public void Print()
        {
            Console.WriteLine($"Hours : {Hours}, Miniutes : {Minute}, Seconds : {Second}");
        }

        public static Duration operator + ( Duration firstInput, Duration secondInput ) { 

            return new Duration(firstInput.Hours + secondInput.Hours,firstInput.Minute+secondInput.Minute
                ,firstInput.Second+secondInput.Second);
        }

        public static bool operator >( Duration firstInput, Duration secondInput ) {

            
            return firstInput.TotalSeconds > secondInput.TotalSeconds;
        }
        public static bool operator <( Duration firstInput, Duration secondInput ) {

           return !(firstInput>secondInput);
            
        }


        public int TotalSeconds => Hours * 3600 + Minute * 60 + Second;



    }
}
