using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitapvenhabuoi8
{
    public class Bai4
    {
        public static List<int> SoLanXuatHien(List<int> nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < k; i++)
            {
                int maxFreq = 0;
                int maxKey = 0;
                foreach (var pair in frequencyMap)
                {
                    if (pair.Value > maxFreq)
                    {
                        maxFreq = pair.Value;
                        maxKey = pair.Key;
                    }
                }
                result.Add(maxKey);
                frequencyMap.Remove(maxKey);
            }

            return result;
        }
    }
}