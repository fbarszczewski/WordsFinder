using System.Collections.Generic;
using System.Linq;

namespace scrabbleMoreAble.Workers
{
    class WordMatcher
    {
        public List<string> MatchedWords { get; private set; }

        public void Match(string[] wordList,string scrambled)
        {
            IEnumerable<string> matched = from word in wordList
                                          where word.GroupBy(g => g).All(g => scrambled.Count(l => l == g.Key) >= g.Count()) 
                                          select word;

            MatchedWords = matched.ToList();
        }
       
    }
}
