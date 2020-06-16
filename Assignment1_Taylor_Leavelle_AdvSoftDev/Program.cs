using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Taylor_Leavelle_AdvSoftDev
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArrayStats operation = new ArrayStats();
            
            int min = 1;
            int max = 101;
           // bool yesorno = false;
           // char answer;

           
          //  do
            //    {
            Console.WriteLine("How big do you want your array?");
            int array_size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] array_original = new int[array_size];
            Random randNum = new Random();
            for (int x=0; x< array_original.Length; x++) 
            { 
                 array_original[x] = randNum.Next(min, max); 
   
            }
            foreach (int n in array_original)
            {
                Console.Write(n + " | ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("The smallest number in your array is: ");
            int smallest_num = operation.findmin(array_original);
            Console.WriteLine(smallest_num);
            Console.WriteLine();
            int biggest_num = operation.findmax(array_original);
            Console.Write("The biggest number in your array is: ");
            Console.WriteLine(biggest_num);
            Console.WriteLine();
            Console.Write("The mean of all the random elements in your array is: ");
            double mean = operation.findavg(array_original);
            Console.WriteLine(mean);
            Console.WriteLine();
            Console.Write("The median of all the random elements in your array is: ");
            int median = operation.findmed(array_original);
            Console.WriteLine(median);
            Console.WriteLine();
            Console.Write("The standard deviation of all the random elements in your array is: ");
            double std = operation.findstd(array_original,  mean);
            Console.WriteLine(std);
            Console.WriteLine();
            int nummethodinvokes = ArrayStats.numberofmethodinvokes;
            Console.WriteLine("This is how many times you called methods from the ArrayStats class : "+ nummethodinvokes);
            Console.WriteLine(); 
            Console.WriteLine();
            Console.ReadLine();

            /*Console.WriteLine("Would you like to run this program again? Type 'y' for yes 'n' for no: ");
            answer = Console.ReadLine();
            if (answer == 'y')
            {yesorno=true;}
            else (answer = false;)
            Console.WriteLine();
            Console.WriteLine("_________________________________________________");
            Console.WriteLine();
            } while (yesorno == true) ;
            Console.ReadLine();
            */












        }
















    }
}
