using System;

namespace ILP
{
    public class Log
    {
      //  public static System.IO.StreamWriter file = null;
            
        public static void log(string s)
        {
                 using (System.IO.StreamWriter file =
                   new System.IO.StreamWriter(@"resultLog.txt", true))
                 {
                     file.Write(s);
                 }
              
        }
        public static void line()
        {
            using (System.IO.StreamWriter file =
              new System.IO.StreamWriter(@"resultLog.txt", true))
            {
                file.WriteLine();
            }
            //file.WriteLine();
        }
    }
}