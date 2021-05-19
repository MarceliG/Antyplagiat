

using Accord.MachineLearning;

namespace Server
{
    public class CompareFiles
    {
        static public double[] bow3;
        
        /// <summary>
        /// Gets a path file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Convert to vectors every signle words on file</returns>
        static public void DoVector(string path)
        {
            string text = MachineLearning.ReadText(path);
            string[] words = text.Tokenize();
            
            bow3 = MachineLearning.codebook.Transform(words);
            
        }

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


        



    }




}
