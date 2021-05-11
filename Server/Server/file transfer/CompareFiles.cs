
using System.IO;

namespace Server
{
    public class CompareFiles
    {

        public string ReadFile(string pathFile1) //, string pathFile
        {
            string readText = null;
            try
            {
                 readText = File.ReadAllText(pathFile1);
            }
            catch (System.Exception)
            {
                readText = "Current path is incorrect";
            }

            return readText;
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
