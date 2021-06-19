using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Server
{
    public class CSV
    {

        static public Book[] ReadCSV()
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\booksummaries.txt";

            StreamReader reader = new StreamReader(File.OpenRead(path));
            List<Book> books = new List<Book>();
            int ileKsiazke = 0;
            while (!reader.EndOfStream && ileKsiazke < 1000) // wczytaj tylko 100 książek 
            {
                ileKsiazke++;
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split('\t');     
                    Book book = new Book(values[2], values[6]);
                    books.Add(book);
                }
            }
           
            Book[] booksTab = books.ToArray();

            return booksTab;

        }

    }
    public class Book
    {
        public string Title { get; }
        public string Summary { get; }

        public Book(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }
    }

}
