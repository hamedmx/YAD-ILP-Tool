using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    public class HashMap
    {
        Dictionary<string, ArrayList> hash = new Dictionary<string, ArrayList>();

        public void Add(string s, Literal c)
        {
            ArrayList al = new ArrayList();
            al.Add(c);
            if (hash.ContainsKey(s))
                hash[s].Add(c);
            else hash.Add(s, al);
        }
        public void clear()
        {
            hash.Clear();

        }
        public Literal[] getList(string key)
        {
            try {
                int cnt = hash[key].Count;
                Literal[] ps = new Literal[cnt];
                int i = 0;
                foreach (Literal p in hash[key])
                {
                    ps[i] = p;
                    i++;
                }

                return ps;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public string[] getKeys()
        {
            
           // foreach(string s in )
                
            return hash.Keys.ToArray<string>();
        }
    }
}
