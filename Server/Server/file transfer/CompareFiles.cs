using Accord.Math.Distances;
using Accord.Math;
using System;
using System.Diagnostics;

namespace Server
{
    public class CompareFiles
    {

        static public double IsItSimilar()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            double[] similary = new double[MachineLearning.bookVectors.Length];
            for (int i = 0; i < MachineLearning.bookVectors.Length; i++)
            {
                // cosine similarity
                Cosine cos = new Cosine();
                similary[i] = cos.Similarity(MachineLearning.bookVectors[i], MachineLearning.clientBookVector);
            }
            stopwatch.Stop();

            double time = stopwatch.ElapsedMilliseconds;
            return time; 
            //return similary;
        }

        //static public float CalculatePercentage(long allVectors, long similar, long theSame)
        //{
        //    float percentage = -1.0f;

        //    if (allVectors != 0)
        //    {
        //        percentage = (((float)similar + (float)theSame) / (float)allVectors) * 100;
        //    }
        //    return percentage;
        //}


    }
}
