using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitapvenhabuoi8
{
    public class Bai2
    {
        public static List<int> TwoSumDictionary(List<int> lst, int target)
        {
            if (!lst.Any()) return null;
            Dictionary<int, int> dic = new Dictionary<int, int>
        {
            { lst[0], 0 }
        };
            for (int i = 1; i < lst.Count; i++)
            {
                var checkNumber = target - lst[i];
                if (dic.ContainsKey(checkNumber))
                {
                    return new List<int> { i, dic[checkNumber] };
                }
                else
                {
                    dic.Add(lst[i], i);
                }
            }
            return null;
        }
    }
}