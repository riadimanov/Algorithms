namespace Algorithms.HackerRank.Easy
{
    /*
     
    HackerLand University has a unique grading policy:
    Every student receives a grade between 0 and 100.
    Any grade less than 40 is a failing grade.
    Sam, a professor at the university, rounds each student’s grade based on the following rules:

    If the difference between the grade and the next multiple of 5 is less than 3, round the grade up to the next multiple of 5.
    If the grade is less than 38, no rounding occurs as the result will still be a failing grade.
    Examples:

    Grade = 84 → Rounded to 85 (because 85–84 is less than 3).
    Grade = 29 → No rounding (result is less than 40).
    Grade = 57 → No rounding (60–57 is 3 or higher).
    Given the initial grade for each of Sam’s students, our task is to write code to automate the rounding process.

    Function Description
    Complete the function gradingStudents in Java. This function takes a list of integer grades and returns a list of rounded grades according to the rules mentioned above.
    */
    internal class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> a = new List<int>();




            for (int i = 0; i < grades.Count; i++)
            {


                if (grades[i] >= 38 && grades[i] % 5 >= 3)
                {
                    a.Add((grades[i] / 5 + 1) * 5);
                }
                else
                {
                    a.Add(grades[i]);
                }
            }
            return a;

        }

    }
}
