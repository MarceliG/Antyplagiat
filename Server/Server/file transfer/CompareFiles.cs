using Accord.Math.Distances;
using Accord.Math;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Server
{
    public class CompareFiles
    {

        static public int[] IsItSimilar(MachineLearning machineLearning)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            double value = 0.0;
            int opposite = 0;
            int similar = 0;
            int allNumbers = 0;
            Cosine cos = new Cosine();
            int[] similarities = new int[3];
            for (int i = 0; i < machineLearning.bookVectors.Length; i++)
            {
                // cosine similarity
                value = cos.Similarity(machineLearning.bookVectors[i], machineLearning.clientBookVector);

                if (value >= 0.6)
                {
                    similar++;
                    Console.WriteLine(machineLearning.books[i].Title);
                }
                else
                {
                    opposite++;
                }
            }
            //stopwatch.Stop();
            allNumbers = similar + opposite;
            similarities[0] = similar;
            similarities[1] = opposite;
            similarities[2] = allNumbers;


            // double time = stopwatch.ElapsedMilliseconds;
            return similarities; 
        }

    }
}
