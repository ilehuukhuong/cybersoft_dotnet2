using System;

namespace Session8;

public class WordCount
{
    public static Dictionary<string, int> WordCountEx(List<string> words)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < words.Count; i++)
        {
            if (result.ContainsKey(words[i]))
            {
                result[words[i]]++;
            }
            else
            {
                result[words[i]] = 1;
            }
        }
        return result;
    }
}
