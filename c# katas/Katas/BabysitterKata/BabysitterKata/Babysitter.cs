using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    public class Babysitter
    {
        public static int beforeBedEarnings = 10;
        public static int afterBedEarnings = 6;
        public static int afterMidnightEarnings = 8;
        static void Main(string[] args)
        {
        }
        public static int CalculateEarnings(int arriveTime, int departTime, int bedTime)
        {
            
                          
            arriveTime = NormalizeHour(arriveTime);
            departTime = NormalizeHour(departTime);
            bedTime = NormalizeHour(bedTime);

            //edge case?
            if (arriveTime == departTime)
            {
                if (arriveTime < bedTime)
                    return 10;
                if (arriveTime >= bedTime && arriveTime < 12)
                    return 6;
                if (arriveTime >= 12)
                    return 8;
            }

            int hoursBeforeBedTime = 0;
            int hoursAfterBed = 0;
            int hoursAfterMidnight = 0;

            hoursBeforeBedTime = departTime > bedTime ? bedTime - arriveTime : departTime - arriveTime;
            hoursAfterMidnight = departTime > 12 ? departTime - 12 : 0;
            hoursAfterBed = departTime > bedTime ? departTime - bedTime - hoursAfterMidnight : 0;


            return hoursBeforeBedTime* beforeBedEarnings + hoursAfterBed*afterBedEarnings + hoursAfterMidnight*afterMidnightEarnings;

        }
        static int NormalizeHour(int hour)
        {
            int newHour = hour;

            if(newHour < 5)
            {
                newHour += 12;
            }

            return newHour;
        }
        
    }
}
