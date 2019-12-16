using System.Collections.Generic;

namespace ExtTesting
{
    public static class ListEstensions
    {
        public static int MySum(this List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
