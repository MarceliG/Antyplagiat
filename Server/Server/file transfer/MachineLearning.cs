using Accord.MachineLearning;
using System.Collections.Generic;
using System.IO;

namespace Server
{


    static public class MachineLearning
    {
        static public double[][] bookVectors;
        static public double[] clientBookVector;

        static private TFIDF codebook = new TFIDF()
        {
            
            Tf = TermFrequency.Log,
            Idf = InverseDocumentFrequency.Default
           
        };

        static public void Learn()
        {
            // create empty table
            //string[] texts = new string[2];

            // Read text
            //string path;
            //path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Montaz_Jan_Felba.txt";
            //texts[0] = ReadText(path);
            //path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Czysty_kod_Robert_Martin.txt";
            //texts[1] = ReadText(path);

            Book[] books = CSV.ReadCSV();
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
        static public void DoVector(string path)
        {
            string text = ReadText(path);
            string[] words = text.Tokenize();

            clientBookVector = codebook.Transform(words);

        }
        //static public void DoVector()
        //{
        //    string path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Montaz_Jan_Felba.txt";
        //    string text = ReadText(path);
        //    string[] words = text.Tokenize();

        //    clientBookVector = codebook.Transform(words);

        //}
    }
}
