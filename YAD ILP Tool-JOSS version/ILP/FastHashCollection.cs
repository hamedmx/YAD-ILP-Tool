using System;
namespace ILP
{
    public class FastHashCollection
    {
        public FastHashCollection() { }
        public int computeHash(string s)
        {
            //var mystring = "abcd";
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(s));
            var ivalue = BitConverter.ToInt32(hashed, 0);
            return ivalue;
        }
    }
}
