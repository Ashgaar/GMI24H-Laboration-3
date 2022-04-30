using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboration_3a quicksort = new Laboration_3a();






            int[] array = { 5,1,3,7,8,4,9,2,6,10 };

            quicksort.Sort(array);
        }
    }
}
