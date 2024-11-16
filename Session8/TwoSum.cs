using System;

namespace Session8;

public class TwoSum
{
    public static List<int> Sum(List<int> lst, int target)
    {
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = i + 1; j < lst.Count; j++)
            {
                if (lst[i] + lst[j] == target)
                {
                    return new List<int> { i, j };
                }
            }
        }
        return null;
    }

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
