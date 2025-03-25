using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class DuplicatesRemoval
    {
        public static void RemoveDuplicates()
        {
            int[] arr = { 1, 2, 2, 3, 5, 4, 6, 6, 3, 7, 8 };
            Dictionary<int,int> dict= new Dictionary<int,int>();
            List<int> uniqueList= new List<int>();
            foreach(int i in arr)
            {
                if (!dict.ContainsKey(i))
                {
                    dict[i] = 1;
                    uniqueList.Add(i);
                }
                else
                {
                    dict[i]++;
                }
            }
            foreach(int i in uniqueList)
            {
                Console.Write(i+" ");
            }
        }
    }
}
