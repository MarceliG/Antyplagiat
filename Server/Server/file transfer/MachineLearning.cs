using Accord.MachineLearning;
using System.IO;

namespace Server
{


    static public class MachineLearning
    {
        
        static public TFIDF codebook = new TFIDF()
        {
            Tf = TermFrequency.Log,
            Idf = InverseDocumentFrequency.Default
        };
        static public double[] bow1;
        static public double[] bow2;

        static public void Learn()
        {
            // create empty table
            string[] texts = new string[2];

            // Read text
            string path;
            path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Montaz_Jan_Felba.txt";
            texts[0] = ReadText(path);
            path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Czysty_kod_Robert_Martin.txt";
            texts[1] = ReadText(path);

            // save every single word to table 
            string[][] words = texts.Tokenize();


            //var codebook = new TFIDF()
            //{
            //    Tf = TermFrequency.Log,
            //    Idf = InverseDocumentFrequency.Default
            //};

            // Compute the codebook (note: this would have to be done only for the training set)
            codebook.Learn(words);
           
                
            // Now, we can use the learned codebook to extract fixed-length
            // representations of the different texts (paragraphs) above:

            // Extract a feature vector from the text 1:
            bow1 = codebook.Transform(words[0]);

            // Extract a feature vector from the text 2:
            bow2 = codebook.Transform(words[1]);

            
        }

      

        public static string ReadText(string path)
        {
            using (StreamReader Reader = new StreamReader(path))
            {
                string fileContent = Reader.ReadToEnd();
                return fileContent;
            }
        }

     
        
    }
}
