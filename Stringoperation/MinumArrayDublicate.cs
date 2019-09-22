using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringoperation
{
   static class MinumArrayDublicate
    {
        static int getMinimumUniqueSum(List<int> arr)
        {

            int sum = 0;

           List<Int32> arrayList = new List<Int32>(arr.Count);
        //    ArrayList arrayList = new ArrayList();
            arrayList.Add(arr[0]);


            for (int i = 1; i < arr.Count; i++)
            {

                int val = arr[i];

                while (arrayList.Contains(val))
                {

                    val++;
                }

                arrayList.Add(val);

            }



            for (int i = 0; i < arrayList.Count(); i++)
            {

                sum += arrayList[i];
            }

            return sum;
        }
    }
}
