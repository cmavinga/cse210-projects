using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            foreach (string word in text.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random rand = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int index = rand.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public string GetDisplayText()
        {
            string scriptureText = "";
            foreach (Word word in _words)
            {
                string displayWord = word.GetDisplayText();
                scriptureText += displayWord + " ";
            }

            return _reference.GetDisplayText() + " - " + scriptureText;
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
