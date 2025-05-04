
namespace Algorithms.HackerRank.Easy
{
    /*
     Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
        Note:
        12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        Example:
        - s = '12:01:00PM': 
           Return '12:01:00'.
        - s = '12:01:00AM': 
           Return '00:01:00'.
        Function Description
        Complete the timeConversion function in the editor. It should return a new string representing the input time in 24-hour format.
        timeConversion has the following parameter(s):
        string s: a time in 12-hour format
        Returns
        string: the time in 24-hour format
    */
    internal class timeConversion
    {
        public static string TimeConversion(string s)
        {
            string prew = s.Substring(s.Length - 2, 2);
            int hours = int.Parse(s.Substring(0, 2));

            string minute = s.Substring(3, 2);
            string secund = s.Substring(6, 2);

            if (prew == "PM")
            {
                if (hours != 12)
                {
                    hours += 12;
                }

            }
            else
            {
                if (hours == 12)
                {
                    hours = 0;
                }
            }

            return ($"{hours:D2}:{minute}:{secund}");
        }

    }

}
