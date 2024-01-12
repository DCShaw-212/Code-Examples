//Name: Dustin Shaw
//Program: Assignment #1
//Date: 02/21/2023

using System;
using System.Linq;
using System.Threading;

namespace Shaw_ParallelProgram_Assignment1
{
    class Program
    {
        //Class Datamembers
        const int numCores = 4;
        const int size = 100000000;
        static int numThreadsDone;
        static int nextid;
        static object locker1 = new object();
        static object locker2 = new object();
        static double parSum;
        static long pSaveTicks;
        static DateTime pt;
        static DateTime st;
        


        static void Main(string[] args)
        {

            DateTime st = DateTime.Now; // time the seq algorithm
            long sSaveTicks = st.Ticks;

            double seqSum = 0.0;
            double fact1 = 0.9999999;

            for (int i = 0; i <= size; i++)
            {
                seqSum += (fact1 * i * i);
                fact1 *= 0.9999999;
            }

            st = DateTime.Now;

            //Output section
            Console.WriteLine("Sequential: " + ((st.Ticks - sSaveTicks) /10000000.0 ) + " seconds");
            Console.WriteLine("Sequential Sum is " + seqSum);

            pt = DateTime.Now;
            pSaveTicks = pt.Ticks;

            for (int i = 0; i < numCores; i++)
            {
                new Thread(ParallelAlgorithm).Start();
            }


        }

        //The parallel algorithm

        static void ParallelAlgorithm()
        {
            int id;
            double localSum = 0;
            double fact1 = 0.9999999;

            lock(locker1)
            {
                id = nextid;
                nextid++;
            }

            int granularity = size / numCores;

            int start = granularity * id + 1;

            Math.Pow(fact1, start);
            for(int i = start; i <= start + granularity; i++)
            {
                localSum += (fact1 * i * i);
                fact1 *= 0.9999999;

            }

            lock(locker2)
            {
                parSum += localSum;
                numThreadsDone++;

                if (numThreadsDone == numCores)
                {
                    pt = DateTime.Now;
                    Console.WriteLine("Parallel: " + ((pt.Ticks - pSaveTicks) / 10000000.0) + " seconds");
                    Console.WriteLine("Parallel Sum is " + parSum);
                }
            }
        }


    }
}
