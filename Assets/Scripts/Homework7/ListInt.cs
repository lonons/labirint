
using System.Collections.Generic;
using System.Linq;

namespace HomeWork7
{
    public class ListInt
    {
        private List<int> List1 = new List<int> {1,2,0,3,4,0,5};

        public int CheckNullCount1(List<int> list)
        {
            int result = 0;
            for (int i = 0;i<list.Count;i++)
            {
                if (list[i] == 0)
                    result++;
            }
            return result;
        }
        public int CheckNullCount2(List<int> list)
        {
            int result = 0;
            foreach(int number in list)
            {
                if (number == 0)
                    result++;
            }
            return result;
        }
        public int CheckNullCount3(List<int> list)
        {
            int result = list.Where(x => x == 0).Count();
            return result;
        }
    }

}
