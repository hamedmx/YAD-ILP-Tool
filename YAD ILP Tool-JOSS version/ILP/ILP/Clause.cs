using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    public class Clause
    {
        public Clause()
        {

        }
        public Dictionary<string, string> replaceList;
        public double score = -1; 
        public Clause clone()
        {
            Clause p = new Clause();
            p.q_side = q_side.clone();

            foreach (Literal c in p_side)
                p.p_side.Add(c.clone());
                    
            return p;
        }

        public int step;
        public double quality = 0;
        public double positiveCoverage;
        public double negativeCoverage;
        public bool similar(Clause p2)
        {
            for (int i = 0; i < p_side.Count; i++)
                if (!((Literal)(p_side[i])).fact.Equals(((Literal)(p2.p_side[i])).fact))
                    return false;
            return true;
        }
        public string getLastLiteral()
        {
            if (p_side != null)
                if (p_side.Count > 0)
                    return p_side[p_side.Count - 1].ToString();
            return "";
        }
        public bool isMoreGeneral(Clause p)
        {
          //  string s1 = ToString();
            string s2 = p.ToString();
            foreach (Literal c in p_side)
            {
                if (!s2.Contains(c.ToString()))
                    return false;
             //   s1 = s1.Replace("X" + i, "X");
               // s2 = s2.Replace("X" + i, "X");
            }
            return true;
        }
        private  int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
        private string _serial = "";
        public string serial()
        {
            if (_serial == "")
            {
                foreach (Literal c in p_side)
                    _serial += c.fact + ";";
               
            }
            return _serial;
        }
        public int maxIndex()
        {
            int max = -1;
            foreach (string s in q_side.items)
                if (s.StartsWith("X"))
                {
                    string u = s.Substring(1);
                    int h = 0;
                    Int32.TryParse(u, out h);
                    if (h > max)
                        max = h;
                }
            foreach (Literal c in p_side)
                foreach (string s in c.items)
                    if (s.StartsWith("X"))
                    {
                        string u = s.Substring(1);
                        int h = 0;
                        Int32.TryParse(u, out h);
                        if (h > max)
                            max = h;
                    }

        
            return max;
        }
        public bool containsMoreThanOne(string key)
        {
            string s = this.ToString();
            if (CountStringOccurrences(s, key) > 1)
                return true;
            else
                return false;
        }
        public int numberOfOccurence(string k)
        {
            
            int cnt = 0;
            foreach (string s in q_side.items)
                if (s == k) cnt ++;
            foreach (Literal c in p_side)
                foreach (string s in c.items)
                    if (s == k) cnt++;

            return cnt;
        }
        public void replace(string s,string d)
        {
            q_side.replace(s, d);
            foreach (Literal c in p_side)
                c.replace(s, d);
            str = "";

        }
        public void changeY2X()
        {
            q_side.changeY2X();
            foreach (Literal c in p_side)
                c.changeY2X();
        }
        string str = "";
        public string ToString()
        {
            if (str != "")
                return str;
            string s = "";
            if (q_side == null)
                s = "";
            else
                s = q_side.ToString() + " :- " ;
            foreach (Literal c in p_side)
                s += c.ToString() + " ; ";
            str = s;
            return s;
        }
        public int countOfConstants()
        {
            int cnt = 0;
            foreach (string s in q_side.items)
                if (!s.StartsWith("X")) cnt++;
            foreach (Literal c in p_side)
                foreach (string s in c.items)
                    if (!s.StartsWith("X")) cnt++;
            return cnt;

        }
        public bool FullyVariable()
        {
            foreach (string s in q_side.items)
                if (!s.StartsWith("X")) return false;
            foreach(Literal c in p_side)
                foreach (string s in c.items)
                    if (!s.StartsWith("X")) return false;
            return true;

        }
        public bool NoVariable()
        {
            foreach (string s in q_side.items)
                if (s.StartsWith("X")) return false;
            foreach (Literal c in p_side)
                foreach (string s in c.items)
                    if (s.StartsWith("X")) return false;
            return true;

        }
        public bool equals(Clause p)
        {
            if (p.ToString().Equals(ToString())) return true;
            else return false;
        }
        public Clause(string s)
        {
            if (s!=null && s != "")
            {
                int i = s.IndexOf(":-");
                if(i==-1) i = s.Length;
                string q_clz = s.Substring(0, i);
                q_side = new Literal(q_clz);

                if (i < s.Length)
                {
                    s = s.Substring(i + 2, s.Length - i - 2);
                    i = s.IndexOf(";");
                    while (i > 0)
                    {
                        string f = s.Substring(0, i);

                        if (i < s.Length)
                        {
                            s = s.Substring(i + 1, s.Length - i - 1);
                            i = s.IndexOf(";");
                            Literal c1 = new Literal(f);
                            p_side.Add(c1);
                        }

                    }
                    if (s != null && s != "" && s!= " ")
                    {
                        Literal c = new Literal(s);
                        p_side.Add(c);
                    }
                }
            }
        }
        public void addPSide(Literal c)
        {
            p_side.Add(c);
            str = "";
        }
        public ArrayList getPSide()
        {
            return p_side;
        }
        private ArrayList p_side = new ArrayList();
       public Literal q_side;
    }
}
