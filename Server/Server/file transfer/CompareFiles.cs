using Accord.Math.Distances;
using Accord.Math;
using System;

namespace Server
{
    public class CompareFiles
    {

        static public double[] IsItSimilar()
        {
            double[] similary = new double[MachineLearning.bookVectors.Length];
            for (int i = 0; i < MachineLearning.bookVectors.Length; i++)
            {
                Cosine cos = new Cosine();
                similary[i] = cos.Similarity(MachineLearning.bookVectors[i], MachineLearning.clientBookVector);
            }

            return similary;
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
