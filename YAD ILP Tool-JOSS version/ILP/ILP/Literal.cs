using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    public class Literal
    {
        public int hash = 0;
        public Literal()
        {

        }
        public bool equals(Literal c)
        {
            if (c.ToString().Equals(ToString())) return true;
            else return false;
        }

        public bool hasVariable()
        {
            if (ToString().Contains("X"))
                return true;
            else
                return false;
        }
        public bool covered = false;
        public bool visited = false;
        public Literal clone()
        {
            Literal c = new Literal();
            c.fact = fact;
            c.hash = hash;
            //c.fact = "*";
            c.items = new ArrayList();
            foreach (string s in items)
                c.items.Add(s);
            return c;
        }
        public void replace(string s, string d)
        {
            for (int i = 0; i < items.Count; i++)
                //string s1 in items.ToArray())
                if (((string)items[i]) == s)
                    items[i] = d;
            // items[i] = ((string)items[i]).Replace(s, d);

            str = "";
        }
        public int serial = 0;
        public void changeY2X()
        {
            for (int i = 0; i < items.Count; i++)
                    items[i] = ((string)items[i]).Replace("Y","X");
        }

        public bool train;
        private string str = "";

        public string ToString()
        {
            if (str != "")
                return str;
            str = fact + "(";
            foreach (string s1 in items)
                str += s1 + ", ";
            str += ")";

            return str;
        }

        public Literal(string s)
        {
            if (s != "") { 
                int i = s.IndexOf("(");
                fact = s.Substring(0, i).Trim();
                s = s.Substring(i + 1, s.Length - i - 2);
                i = s.IndexOf(",");
                
                while (i > 0)
                {
                    string f =  s.Substring(0, i);

                    if (i < s.Length)
                    {
                        s = s.Substring(i + 1, s.Length - i - 1);
                        i = s.IndexOf(",");
                        items.Add(f.Trim());
                    }

                }
                items.Add(s.Trim());
             }
        }
        public string fact;
        public ArrayList items = new ArrayList();

        
    }
}
