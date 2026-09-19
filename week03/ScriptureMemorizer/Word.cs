namespace ScriptureMemorizer
{
    public class Word
    {
        private string _verseWord;
        private bool _isHidden;

        public Word(string verseWord)
        {
            _verseWord = verseWord;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return new string('_', _verseWord.Length);
            }
            else
            {
                return _verseWord;
            }
        }

    }
}
