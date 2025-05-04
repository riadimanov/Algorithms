namespace Algorithms.HackerRank.Easy
{
    /*
    Given an array of integers, calculate the ratios of its elements that are positive,negative and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.
    Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable
    */

    internal class Plus_Minus
    {
        public static void plusMinus(List<int> reqemler)
        {



            double musbetreqem = 0;
            double menfireqem = 0;
            double neqativ = 0;


            for (int i = 0; i < reqemler.Count; i++)
            {




                if (reqemler[i] > 0)
                {
                    musbetreqem++;

                }
                else if (reqemler[i] < 0)
                {
                    menfireqem++;

                }
                else
                    neqativ++;



            }
            Console.WriteLine(musbetreqem / reqemler.Count);
            Console.WriteLine(menfireqem / reqemler.Count);
            Console.WriteLine(neqativ / reqemler.Count);

        }

    }
}
