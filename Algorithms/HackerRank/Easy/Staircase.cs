
namespace Algorithms.HackerRank.Easy 
{ 
    /*Staircase detail

    This is a staircase of size :

       #
      ##
     ###
    ####

    Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
    Write a program that prints a staircase of size .
    Function Description
    Complete the  function with the following parameter(s):
    int n: an integer
    Print a staircase as described above. No value should be returned.
    Note: The last line is not preceded by spaces. All lines are right-aligned.*/

    internal class Staircase
    {
        public static void staircase(int n)
        {



            for (int i = 1; i <= n; i++)

            {
                string a = "";
                for (int b = 0; b < n - i; b++)
                {
                    a += " ";

                }
                for (int d = 1; d <= i; d++)
                {
                    a += '#';

                }
                Console.WriteLine(a);
            }
        }
        }
}
