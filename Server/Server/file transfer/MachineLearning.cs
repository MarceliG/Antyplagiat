using Accord.MachineLearning;
using System.Collections.Generic;
using System.IO;

namespace Server
{


    public class MachineLearning
    {
        public double[][] bookVectors;
        public double[] clientBookVector;
        public Book[] books = CSV.ReadCSV();

        private TFIDF codebook = new TFIDF()
        {
            Tf = TermFrequency.Log,
            Idf = InverseDocumentFrequency.Default
        };


        public void Learn()
        {  
            
            List<string> texts = new List<string>();
            string[] textsTab;
            foreach (var book in books)
            {
                texts.Add(book.Summary);
            }
            //Convert list to Array
            textsTab = texts.ToArray();

            // save every single word to table 
            string[][] words = textsTab.Tokenize();

            // Compute the codebook (note: this would have to be done only for the training set)
            codebook.Learn(words);


            // Now, we can use the learned codebook to extract fixed-length
            // representations of the different texts (paragraphs) above:

            bookVectors = codebook.Transform(words);
        }


        /// <summary>
        /// Gets a path file and read text
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Read file on one string</returns>
        static public string ReadText(string path)
        {
            using (StreamReader Reader = new StreamReader(path))
            {
                string fileContent = Reader.ReadToEnd();
                return fileContent;
            }
        }


        /// <summary>
        /// Gets a path file and make vectors
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Convert to vectors every signle words on file</returns>
        public void DoVector(string path)
        {
            string text = ReadText(path);
            string[] words = text.Tokenize();

            clientBookVector = codebook.Transform(words);
        }
      
    }
}
