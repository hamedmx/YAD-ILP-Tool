using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILP
{
    public class Substitution
    {
        public  ArrayList pairs = new ArrayList();
        public void add(string key, string value)
        {
            KeyValuePair<string, string> kv = new KeyValuePair<string, string>(key, value);
            pairs.Add(kv);
        }

    }
  
    public class ResolutionManager
    {
        FastHashCollection fastHash = new FastHashCollection();
        //    ArrayList substitutionList = new ArrayList();
        public ArrayList findAllPossibleReplacement(Literal cls)
        {
            ArrayList result = new ArrayList();
            ArrayList back = fastHash.getBackgrounds();
            foreach (Literal c in back)
            {
               
                    Substitution substitution = new Substitution();
                    bool flag = true;
                    if (c.fact.Equals(cls.fact))
                    {
                    try
                    {
                        for (int i = 0; i < c.items.Count; i++)
                        {
                            string s1 = (string)c.items[i];
                            string s2 = (string)cls.items[i];
                            if (s2.StartsWith("X"))
                                substitution.add(s2, s1);
                            else if (!s1.Equals(s2))
                                flag = false; // if they are different in constant value, then they cannot be the same e.g. egg(a1,false) and egg(X0,true)
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(cls.ToString()+"----"+c.ToString());
                    }
                    if (flag)
                            result.Add(substitution);
                    
                }
                
            }
            return result;

        }
        public bool checkExistanceOfAllClauses(Clause p)
        {
           
            foreach (Literal c in p.getPSide())
                if (!fastHash.inBackground(c))
                    return false;
            return true;
        }
        public bool checkCoverage(Clause p, Literal cls)
        {
     //       Console.WriteLine(p.ToString());
       //     Console.WriteLine(cls.ToString());
          
            Substitution substitution = new Substitution();
            bool flag = true;
            if (p.q_side.fact.Equals(cls.fact))
            {
                for (int i = 0; i < cls.items.Count; i++)
                {
                    string s2 = (string)p.q_side.items[i];
                    string s1 = (string)cls.items[i];
                    if (s2.StartsWith("X"))
                        substitution.add(s2, s1);

                    else if (!s1.Equals(s2))
                        flag = false; // if they are different in constant value, then they cannot be the same e.g. egg(a1,false) and egg(X0,true)
                }
                if (flag)
                    foreach (KeyValuePair<string, string> kv in substitution.pairs)
                        p.replace(kv.Key, kv.Value);
                else return false;
            }
            else
                return false;
            while (true) {
           //     Binding b = new Binding();
                Literal min = null;
                int minChoice = 100000000;
                bool novariable = true;
                foreach (Literal c2 in p.getPSide())
                {
                    if (c2.hasVariable())
                    {
                        novariable = false;
                        ArrayList result = findAllPossibleReplacement(c2);
                        if (result.Count < minChoice)
                        {
                            minChoice = result.Count;
                            min = c2;
                        }
                        if (result.Count == 1)
                            break;
                        
                    }

                }
                if (novariable)
                    if (checkExistanceOfAllClauses(p))
                        return true;
                    else return false;
                if (minChoice == 0)
                    return false;
                else if (minChoice == 1)
                {
                    ArrayList ar = findAllPossibleReplacement(min);
                    Substitution s = (Substitution)ar[0];
                    foreach(KeyValuePair<string,string> kv in s.pairs)
                        p.replace(kv.Key,kv.Value);
                }else if (minChoice > 1)
                {
                    ArrayList ar = findAllPossibleReplacement(min);
                    Substitution s = (Substitution)ar[0];
                    foreach (KeyValuePair<string, string> kv in s.pairs)
                        p.replace(kv.Key, kv.Value);
                }//TODO: more than one
            }
            
        }

    }
    
}
