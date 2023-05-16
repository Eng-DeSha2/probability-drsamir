using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("enter number {0}", i);
                array[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int n = array.Length;

            //  median
            double median;
            if (n % 2 == 0)
            {
                median = (array[n / 2] + array[(n / 2) - 1]) / 2;
            }
            else
            {
                median = array[n / 2];
            }

            //  quartile (Q1 , Q2 , Q3)
            int q1 = (int)array[(int)Math.Floor((double)n * 0.25)];
            double q2 = array[n/2];
            int q3 = (int)array[(int)Math.Floor(n * 0.75)];
            
            //outlieres 
            double IQR = q3 - q1;
            double lwl = q1 - 1.5 * (IQR);
            double Rwl = q3 + 1.5 * (IQR);
            double lcl = q1 - 3 * (IQR);

            //  percentile (P90)
            int p90 = (int)array[(int)Math.Floor((double)n / 90)];

       
     
            //   range
            int range = (int)(array.Max() - array.Min());

           
            //  standard deviation
            double mean = array.Average();
            double sumOfSquares = array.Sum(x => Math.Pow(x - mean, 2));
            double standardDeviation = Math.Sqrt(sumOfSquares / n);

            // summation of deviations
            double summationOfDeviations = array.Sum(x => Math.Abs(x - mean));
            // mode//
            int old_num1 = 0;
            int new_num2 = 0;
            int mode = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = i + 1; j < number; j++)
                {
                    if (array[i] == array[j])
                    {
                        new_num2 += 1;
                    }
                }
                if (new_num2 > old_num1)
                {
                    old_num1 = new_num2;
                    mode = (int)array[i];
                }
            }


            // output 
            Console.WriteLine("Data = " + string.Join(", ", array));
            Console.WriteLine("Median = " + median);
            Console.WriteLine("Mode = {0}" , Mode(array));
            Console.WriteLine("Q1 = " + q1);
            Console.WriteLine("Q2 = " + q2);
            Console.WriteLine("Q3 = " + q3);
            Console.WriteLine("IQR = "+ IQR);
            Console.WriteLine("LWL = " + lwl);
            Console.WriteLine("RWL = " + Rwl);
            Console.WriteLine("LCL = " + lcl);
            Console.WriteLine("P90 = " + p90);
            Console.WriteLine("Range = " + range);
            Console.WriteLine("Summation of Deviations = " + summationOfDeviations);
            Console.WriteLine("Standard Deviation = " + standardDeviation);
            Console.ReadKey();
        }
     
       



    }


}

