

using Accord.MachineLearning;

namespace Server
{
    public class CompareFiles
    {

        /// <summary>
        /// Gets a path file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Convert to vectors every signle words on file</returns>
        public double[] DoVector(string path)
        {
            string text = MachineLearning.ReadText(path);
            string[] words = text.Tokenize();

            var codebook = new TFIDF()
            {
                Tf = TermFrequency.Log,
                Idf = InverseDocumentFrequency.Default
            };

            double[] bow = codebook.Transform(words);

            return bow;
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
