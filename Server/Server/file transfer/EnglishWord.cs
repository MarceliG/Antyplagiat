namespace ServerDictionary.TFIDFExample
{
    internal class EnglishWord
    {
        internal readonly string Stem;
        private string stripped;

        public EnglishWord(string stripped)
        {
            this.stripped = stripped;
        }
    }
}