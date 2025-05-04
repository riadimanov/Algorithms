namespace Algorithms.HackerRank.Easy
{ /*
   Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
    Example: arr=[1,1,2,2,3}
    There are two each of types  and , and one sighting of type . Pick the lower of the two types seen twice: type .
    Function Description:
    Complete the migratoryBirds function in the editor below.
    migratoryBirds has the following parameter(s):
    int arr[n]: the types of birds sighted
    Returns:
    int: the lowest type id of the most frequently sighted birds
    */
    internal class Migratory_Birds
    {

        public static int migratoryBirds(List<int> arr)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();



            foreach (int item in arr)
            {
                if (dict.TryGetValue(item, out int value))
                {
                    dict[item] = value += 1;
                }
                else
                { dict.Add(item, 1); }
            }

            int maxvalue = 0;
            int minkey = 0;

            foreach (var v in dict)
            {
                if (v.Value > maxvalue)

                {
                    maxvalue = v.Value;
                    minkey = v.Key;
                }
                else if (maxvalue == v.Value && v.Key < minkey)
                {
                    minkey = v.Key;
                }

            }
            return minkey;
        }

    }

}

