using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session7
{
    public class Bai3
    {
        public static List<string> TimChuoiBatDauLaM(List<string> strings)
        {
            List<string> list = new List<string>();
            foreach (string s in strings)
            {
                if (s.ToLower().StartsWith("m")) list.Add(s);
            }
            return list;
        }
    }
}