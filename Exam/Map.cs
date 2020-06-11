using System;
using System.Collections.Generic;

namespace Examen
{
    public class Map
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> words = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            words.Add("a", new Dictionary<string, Dictionary<string, string>>());
            words["a"].Add("b", new Dictionary<string, string>());
            words["a"].Add("", new Dictionary<string, string>());
            words["a"]["b"].Add("c", "12");
            words["a"]["b"].Add("d", "Hello World");
            words["a"][""].Add("e", "1,2,3");           
            foreach (KeyValuePair<string, string> d in FuncFlat(words))
            {
                Console.WriteLine(d.Key + " : " + d.Value);
            }
        }
        public static Dictionary<string, string> FuncFlat(Dictionary<string, Dictionary<string, Dictionary<string, string>>> words)
        {
            Dictionary<string, string> wordsFlat = new Dictionary<string, string>();
            foreach (string a in words.Keys)
            {
                foreach (string b in words[a].Keys)
                {
                    foreach (KeyValuePair<string, string> c in words[a][b])
                    {
                        string flat = a;
                        if (b != "")
                        {
                            flat += "/" + b + "/" + c.Key;
                        }
                        else
                        {
                            flat += b + "/" + c.Key;
                        }
                        wordsFlat.Add(flat, c.Value);
                    }
                }
            }           
            return wordsFlat;
        }
    }
}
