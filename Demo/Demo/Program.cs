using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
  public  class demo
    {
        private int x = 10;    // x=5;
        public void Print()
        {
            Console.WriteLine(x);
        }
    }
    
    class xyz: demo
    {

    }
    class Program
    {
        public static void SetPrivateVariable(System.Type t, string varName, object varValue, object objInstance)
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            FieldInfo pi;

            pi = t.GetField(varName, eFlags);
            if (pi != null)
                pi.SetValue(objInstance, varValue);
        }
        static void Main(string[] args)
        {
            demo obj = new demo();
            SetPrivateVariable(typeof(demo), "x", 5, obj);
            Console.Read();
          
        }
    }
}
