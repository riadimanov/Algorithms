namespace Algorithms.HackerRank.Easy
{
   /*You are in charge of the cake for a child's birthday. It will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Your task is to count how many candles are the tallest The tallest candles are 4 units high. There are 2 candles with this height, so the function should return 2.
  
   Function Description

Complete the function birthdayCakeCandles with the following parameter(s):
    int candles [n]: the candle heights
  */
    internal class birthdayCakeCandles
    {
        public static int  BirthdayCakeCandles(List<int> reqemler)
        {




            for (int i = 0; i < reqemler.Count; i++)
            {


            }

            int max = reqemler[0];
            int maxsayi = 0;


            for (int i = 0; i < reqemler.Count; i++)
            {
                if (max < reqemler[i])
                {
                    max = reqemler[i];
                    maxsayi = 1;
                }

                else if (max == reqemler[i])
                {
                    maxsayi++;

                }
            }



            return maxsayi;


        }

    }
}
