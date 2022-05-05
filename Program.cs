using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using LaborationInterfaces;
using System.IO;
    
namespace Olsson_Mikael
{
    class Program
    {
        List<double> times = new List<double>();
        static void Main(string[] args)
        {
            Mikael_Olsson_PostfixCalculator lab = new Mikael_Olsson_PostfixCalculator();
            string input1 = "1 2 +";
            string input2 = "5 6 7 + -";
            string input3 = "-2";
            string input4 = "40 3 4 * -8 + /";
            string input5 = "-1 -1 -";
            string input6 = "1.1 2.1 -";

            Console.WriteLine("Running calculator");
            Console.WriteLine($"Running calculate with input {input1}");
            Console.WriteLine(lab.Calculate(input1));
            Console.WriteLine($"Running calculate with input {input2}");
            Console.WriteLine(lab.Calculate(input2));
            Console.WriteLine($"Running calculate with input {input3}");
            Console.WriteLine(lab.Calculate(input3));
            Console.WriteLine($"Running calculate with input {input4}");
            Console.WriteLine(lab.Calculate(input4));
            Console.WriteLine($"Running calculate with input {input5}");
            Console.WriteLine(lab.Calculate(input5));
            Console.WriteLine($"Running calculate with input {input6}");
            Console.WriteLine(lab.Calculate(input6));

            Console.WriteLine(1 + "*" + 2);

            //Laboration_3d lab3 = new Laboration_3d();
            ////Console.WriteLine(lab3.Top());
            //Console.WriteLine(lab3.Size());

            //lab3.Push(5);
            //lab3.Push(6);
            //Console.WriteLine(lab3.Size());
            //Console.WriteLine(lab3.Top());
            //Console.WriteLine(lab3.Pop());
            //Console.WriteLine(lab3.Top());
            //lab3.Push(7);
            //Console.WriteLine(lab3.Top());
            //lab3.Clear();
            //Console.WriteLine(lab3.Size());

            //Random random = new Random();
            //Stopwatch stopwatch = new Stopwatch();
            //Program program = new Program();


            //Laboration_3a quickSort = new Laboration_3a();
            //Laboration_3b insertionSort = new Laboration_3b();
            //Laboration_3c selectionSort = new Laboration_3c();


            //for (int l = 0; l < 5; l++)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int based = 2500000;
            //        int increment = 750000;
            //        int runs = based + i * increment;

            //        Console.WriteLine($"Phase {i + 1} out of 10, using size {runs}");

            //        int[] arrayRuns = new int[runs];

            //        for (int j = 1; j < arrayRuns.Length; j++)
            //        {
            //            arrayRuns[j] = j;
            //        }

            //        //for (int j = 0; j < arrayRuns.Length; j++)
            //        //{
            //        //    arrayRuns[j] = random.Next(0, 500000);
            //        //}

            //        //Console.WriteLine(arrayRuns.Length);
            //        //Console.WriteLine(arrayRuns[0]);
            //        //Console.WriteLine(arrayRuns[1]);
            //        //Console.WriteLine(arrayRuns[2]);

            //        int[] arrayRuns2 = new int[arrayRuns.Length];
            //        int[] arrayRuns3 = new int[arrayRuns.Length];

            //        for (int k = 0; k < arrayRuns.Length; k++)
            //        {
            //            arrayRuns2[k] = arrayRuns[k];
            //            arrayRuns3[k] = arrayRuns[k];
            //        }

            //        stopwatch.Restart();
            //        quickSort.Sort(arrayRuns);
            //        stopwatch.Stop();
            //        var elapsed1 = stopwatch.ElapsedMilliseconds;
            //        program.times.Add(elapsed1);

            //        //stopwatch.Restart();
            //        //insertionSort.Sort(arrayRuns2);
            //        //stopwatch.Stop();
            //        //var elapsed2 = stopwatch.ElapsedMilliseconds;
            //        //program.times.Add(elapsed2);

            //        //stopwatch.Restart();
            //        //selectionSort.Sort(arrayRuns3);
            //        //stopwatch.Stop();
            //        //var elapsed3 = stopwatch.ElapsedMilliseconds;
            //        //program.times.Add(elapsed3);


            //        //Console.WriteLine($"{elapsed1},{elapsed2},{elapsed3}");
            //    }
            //    Console.WriteLine("writing to file");
            //    //runTimenewimprovedquicksort
            //    //runTimenewquicksort
            //    program.writeTimesToFile($"../../runTimegiganormalpivot.csv");
            //}




            //bool verbose = false;
            //bool timer = true;
            //Stopwatch stopWatch = new Stopwatch();

            //Laboration_3a quickSort = new Laboration_3a();
            //Laboration_3b insertionSort = new Laboration_3b();
            //Laboration_3c selectionSort = new Laboration_3c();

            //int[] array = { 0,1,2,3,-4,5,6,7,-8,9,-10};

            //stopWatch.Start();
            //quickSort.Sort(array);
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.ElapsedMilliseconds) ;
            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}


            //for(int i = 1;i < 10;i++)
            //{

            //}

            //YES

            //Console.WriteLine("Selection sort: ");
            //int[] array1 = { 2, 6, 5, 0, 8, 9, 1, 3 };

            //selectionSort.Sort(array1);

            //if (verbose == true)
            //{
            //    foreach (var item in array1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //if (timer == true)
            //{
            //    Console.WriteLine("Time: " + selectionSort.Time);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Insertion sort: ");
            //int[] array2 = { 2, 6, 5, 0, 8, 9, 1, 3 };

            //insertionSort.Sort(array2);
            //if (verbose == true)
            //{
            //    foreach (var item in array2)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("Quick sort: ");
            //int[] array3 = { 2, 6, 5, 0, 8, 9, 1, 3 };

            //quickSort.Sort(array3);

            //if (verbose == true)
            //{
            //    foreach (var item in array3)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine();


            //Console.WriteLine("Försök med jämn array och unika värden");
            //Console.WriteLine();
            //int[] arrayEven = { 2, 4, 1, 5, 3, 6, 0 };

            //quickSort.Sort(arrayEven);

            //if (verbose == true)
            //{
            //    foreach (var item in arrayEven)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Försök med ojämn array och unika värden");
            //Console.WriteLine();
            //int[] array = { 5, 1, 3, 7, 8, 4, 0, 9, 2, 6, 10 };

            //quickSort.Sort(array);
            //if (verbose == true)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //Console.WriteLine();
            //Console.WriteLine("Försök med ojämn större array och unika värden");
            //Console.WriteLine();
            //int[] arrayBig = { 10, 15, 17, 16, 7, 19, 4, 11, 9, 13, 6, 0, 1, 2, 20, 5, 3, 12, 14, 8, 18 };


            //quickSort.Sort(arrayBig);
            //if (verbose == true)
            //{
            //    foreach (var item in arrayBig)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //Console.WriteLine("Icke unika värden");
            //int[] arraylol = { 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 8, 8, 8, 9, 1, 2, 4 };

            //quickSort.Sort(arraylol);
            //if (verbose == true)
            //{
            //    foreach (var item in arraylol)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            Console.WriteLine("We are done");
            Console.ReadLine();
        }


        public void writeTimesToFile(string fileName)
        {
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < times.Count; i++/*+=3*/)
                {
                    //var line = string.Format("{0},{1},{2}", times[i], times[i + 1], times[i + 2]);
                    writer.WriteLine(times[i] /*+ ";" + times[i + 1] + ";" + times[i + 2]*/);
                }
                //foreach (double time in times)
                //{
                //    writer.WriteLine(time);
                //}
            }
        }
    }
}
