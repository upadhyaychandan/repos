using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    public class Parameter
    {
        public Parameter()
        {
            IsOptional = true;
        }

        public bool? IsOptional { get; set; }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Parameter obj = new Parameter();
            int counter = 0;
            string parameter = "holduntil";
            if (parameter != null && !string.IsNullOrEmpty(parameter) && parameter.ToLower() == "holduntil")
            {
                counter++;
            }
            if ((obj.IsOptional.Value))
            {

            }
            
        }
    }
}
