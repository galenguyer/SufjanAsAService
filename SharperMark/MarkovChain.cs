using System;
using System.Collections.Generic;
using System.Linq;

namespace SharperMark
{
    public class MarkovChain
    {
        private List<MarkovNode> Nodes;
        private List<string> StartingWords;

        public MarkovChain()
        {
            this.Nodes = new List<MarkovNode>();
            this.StartingWords = new List<string>();
        }

        public string GenerateSentence()
        {
            string sentence = StartingWords.GetRandomItem(); ;
            MarkovNode currentNode = Nodes.Find(n => n.Word == sentence);
            while(true)
            {
                string currentWord = currentNode.GetNextWord();
                if (currentWord == "__END__")
                    break;

                sentence += " " + currentWord;
                currentNode = Nodes.Find(n => n.Word == currentWord);
            }

            return sentence;
        }

        public MarkovChain Train(string[] input)
        {
            foreach(string inputString in input)
            {
                var words = inputString.Split().Where(w => !string.IsNullOrEmpty(w)).ToArray();
                if (words.Length == 0)
                    continue;

                StartingWords.Add(words[0]);
                int stop = words.Length - 1;
                for (int i = 0; i < stop; i++)
                {
                    if(!Nodes.Any(n => n.Word == words[i]))
                    {
                        Nodes.Add(new MarkovNode(words[i]));
                    }
                    Nodes.Find(n => n.Word == words[i]).AddNextWord(words[i+1]);
                }

                if (!Nodes.Any(n => n.Word == words[stop]))
                {
                    Nodes.Add(new MarkovNode(words[stop]));
                }
                Nodes.Find(n => n.Word == words[stop]).AddNextWord("__END__");
            }
            return this;
        }
    }
}
