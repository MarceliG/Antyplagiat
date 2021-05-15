using Accord.MachineLearning;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Server
{
    class MachineLearning
    {
        static public void Learn()
        {



            string[] texts = new string[2];
            /*
                 {
     @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas molestie malesuada 
      nisi et placerat. Curabitur blandit porttitor suscipit. Nunc facilisis ultrices felis,
      vitae luctus arcu semper in. Fusce ut felis ipsum. Sed faucibus tortor ut felis placerat
      euismod. Vestibulum pharetra velit et dolor ornare quis malesuada leo aliquam. Aenean 
      lobortis, tortor iaculis vestibulum dictum, tellus nisi vestibulum libero, ultricies 
      pretium nisi ante in neque. Integer et massa lectus. Aenean ut sem quam. Mauris at nisl 
      augue, volutpat tempus nisl. Suspendisse luctus convallis metus, vitae pretium risus 
      pretium vitae. Duis tristique euismod aliquam",

    @"Sed consectetur nisl et diam mattis varius. Aliquam ornare tincidunt arcu eget adipiscing. 
      Etiam quis augue lectus, vel sollicitudin lorem. Fusce lacinia, leo non porttitor adipiscing, 
      mauris purus lobortis ipsum, id scelerisque erat neque eget nunc. Suspendisse potenti. Etiam 
      non urna non libero pulvinar consequat ac vitae turpis. Nam urna eros, laoreet id sagittis eu,
      posuere in sapien. Phasellus semper convallis faucibus. Nulla fermentum faucibus tellus in 
      rutrum. Maecenas quis risus augue, eu gravida massa."
                };
            */
            //string[] tekst = new string[2];
            string path;
            path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Montaz_Jan_Felba.txt";
            texts[0] = ReadText(path);
            path = @"D:\STUDIA\Programowanie obiektowe\Antyplagiat\Antyplagiat\ksiazki\Czysty_kod_Robert_Martin.txt";
            texts[1] = ReadText(path);

            // save every single word to table 
            string[][] words = texts.Tokenize();

            // Create a new TF-IDF with options:
            var codebook = new TFIDF()
            {
                Tf = TermFrequency.Log,
                Idf = InverseDocumentFrequency.Default
            };

            // Compute the codebook (note: this would have to be done only for the training set)
            codebook.Learn(words);


            // Now, we can use the learned codebook to extract fixed-length
            // representations of the different texts (paragraphs) above:

            // Extract a feature vector from the text 1:
            double[] bow1 = codebook.Transform(words[0]);

            // Extract a feature vector from the text 2:
            double[] bow2 = codebook.Transform(words[1]);

            
        }
        
        static string ReadText(string path)
        {
            using (StreamReader Reader = new StreamReader(path))
            {
                string fileContent = Reader.ReadToEnd();
                return fileContent;
            }
        }
    }
}
