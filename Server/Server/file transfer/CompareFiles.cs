using Accord.Math.Distances;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Server
{
    public class CompareFiles
    {

        static public int[] FindSimilarBooks(double[][] bookVectors, double[] clientBookVector)
        {

            double value = 0.0;

            List<int> bookIndexes = new List<int>();
            Cosine cos = new Cosine();
          
            
            for (int i = 0; i < bookVectors.Length; i++)
            {
                // cosine similarity
                value = cos.Similarity(bookVectors[i], clientBookVector);

                if (value >= 0.5)
                {
                    bookIndexes.Add(i);
                }
            }
            
            return bookIndexes.ToArray(); 
        }

    }
}
