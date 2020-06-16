using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Taylor_Leavelle_AdvSoftDev
{
    class ArrayStats
    {
        public static int numberofmethodinvokes;

        public int findmin(int[] array)
        {
            int smallest = array[0];
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < smallest)
                {
                    smallest = array[x];
                }
            }
            numberofmethodinvokes += 1;

            return smallest;
        }

        public int findmax(int[] array)
        {
            int biggest = array[0];
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > biggest)
                {
                    biggest = array[x];
                }
            }
            numberofmethodinvokes += 1;
            return biggest;
        }

        public double findavg(int[] array)
        {
            double total = 0;
            double avg = 0;
            for (int x = 0; x < array.Length; x++)
            {
                total += array[x];
                avg = total / array.Length;
            }
            numberofmethodinvokes += 1;
            return avg;
        }

        public int findmed(int[] array)
        {
            int smallest = array[0];
            int biggest = array[0];
            int median = 0;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > biggest)
                {
                    biggest = array[x];
                }
                if (array[x] < smallest)
                {
                    smallest = array[x];
                }
            }
            numberofmethodinvokes += 1;
            median = biggest - smallest;
            return median;
        }

        public double findstd(int[] array, double mean)
        {


            double sumofsqs = 0.0;

            foreach (int n in array)
            {
                sumofsqs += Math.Pow((n - mean), 2.0);
            }
            double stdvar = sumofsqs / (double)(array.Length);
            numberofmethodinvokes += 1;
            return Math.Sqrt(stdvar);


        }
        

    }
}
