using Accord.Math.Distances;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Server
{
    public class CompareFiles
    {

        static public int[] IsItSimilar(MachineLearning machineLearning)
        {

            double value = 0.0;

            List<int> bookIndexes = new List<int>();
            Cosine cos = new Cosine();
          
            
            for (int i = 0; i < machineLearning.bookVectors.Length; i++)
            {
                // cosine similarity
                value = cos.Similarity(machineLearning.bookVectors[i], machineLearning.clientBookVector);

                if (value >= 0.5)
                {
                    bookIndexes.Add(i);
                    Console.WriteLine("Tytuły książek: " + machineLearning.books[i].Title);
                }
            }
            
            return bookIndexes.ToArray(); 
        }

    }
}
