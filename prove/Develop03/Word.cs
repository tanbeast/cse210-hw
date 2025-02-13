class Word
    {
        private string _Text { get; set; }
        public bool _IsHidden { get; private set; }

        public Word(string text)
        {
            _Text = text;
            _IsHidden = false;
        }

        // Hide the word
        public void Hide()
        {
            _IsHidden = true;
        }

        // Get the text to display (hidden or shown)
        public string GetDisplayText()
        {
            if (_IsHidden)
            {
                return new string('_', _Text.Length);
            }
            else
            {
                return _Text;
            }
        }
    }