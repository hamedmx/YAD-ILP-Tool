using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace ILP
{
    public class FastHashCollection
    {
       static int size = 10000;
        MD5 md5Hasher = MD5.Create();

        public FastHashCollection() { }
        public int computeHash(string s)
        {
            //var mystring = "abcd";
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(s));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            int res = Math.Abs(ivalue % size);
            return res;
        }
        private static ArrayList[] backgrounds = new ArrayList[size];
        private static ArrayList[] predicates = new ArrayList[size];
        public bool inBackground(Literal c)
        {
            int h = computeHash(c.ToString());
            foreach (Literal p1 in backgrounds[h])
                if (p1.equals(c))
                    return true;
            return false;


        }
        static ArrayList back = new ArrayList();
        static bool cache = false;
        public ArrayList getBackgrounds()
        {
            if (!cache)
            {
                back = new ArrayList();
                cache = true;
                for (int i = 0; i < size; i++)
                    foreach (Literal c in backgrounds[i])
                        back.Add(c);
            //    return back;
            }
            return back;
            //TODO
        }
        public void clearBackgrounds()
        {
            for (int i = 0; i < size; i++)
                backgrounds[i] = new ArrayList();//.Clear();
        }
        public void clearPredicates()
        {
            for (int i = 0; i < size; i++)
                predicates[i] = new ArrayList();
        }
        public void addPredicate(Clause p)
        {
            int h = computeHash(p.ToString());
            predicates[h].Add(p);
        }
        public void addBackground(Literal c)
        {
            int h = computeHash(c.ToString());
            c.hash = h;
            backgrounds[h].Add(c);
        }
    }
}
