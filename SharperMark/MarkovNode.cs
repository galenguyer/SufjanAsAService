using System;
using System.Collections.Generic;
using System.Text;

namespace SharperMark
{
    class MarkovNode
    {
        public string Word;
        private List<string> NextWordOccurences;

        public MarkovNode(string word)
        {
            this.Word = word;
            this.NextWordOccurences = new List<string>();
        }

        public string GetNextWord()
        {
            return this.NextWordOccurences.GetRandomItem(); ;
        }

        public MarkovNode AddNextWord(string word)
        {
            NextWordOccurences.Add(word);

            return this;
        }
    }
}
