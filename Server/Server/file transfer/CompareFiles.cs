

using Accord.MachineLearning;
using System;

namespace Server
{
    public class CompareFiles
    {

        public int WordCount(string text)
        {
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            return wordCount;
        }


        static public long[] IsItSimilar()
        {
            int lenghtBow = MachineLearning.bow1.Length;
            long[] table = new long[2];
            long similar = 0;
            long allVectors = 0;
            double distance;
            // Euclidean space
            for (int i = 0; i < lenghtBow; i++)
            {
                for (int j = 0; j < lenghtBow; j++)
                {
                    distance = Math.Sqrt(Math.Pow(MachineLearning.bow3[i] - MachineLearning.bow1[j], 2));
                    if (distance == 0) {
                        continue;
                    }
                    allVectors++;
                    if (distance <= 0.1)
                    {
                    similar++;
                    }
                }
            }
            table[0] = allVectors;
            table[1] = similar;
            return table;
            //return similar;
        }

        static public float CalculatePercentage(long allVectors, long similar)
        {
            float percentage = -1.0f;

            if(similar != 0)
            {
                percentage = (similar / allVectors) * 100;
            }
            return percentage;
        }


    }




}
