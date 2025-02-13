class Reference
    {
        public string _Book { get; private set; }
        public int _Chapter { get; private set; }
        public int _Verse { get; private set; }
        public int? _EndVerse { get; private set; }  // Nullable for single verses

        public Reference(string book, int chapter, int verse)
        {
            _Book = book;
            _Chapter = chapter;
            _Verse = verse;
            _EndVerse = null;
        }
        
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _Book = book;
            _Chapter = chapter;
            _Verse = startVerse;
            _EndVerse = endVerse;
        }

        public override string ToString()
        {
            if (_EndVerse.HasValue)
            {
                return $"{_Book} {_Chapter}:{_Verse}-{_EndVerse}";
            }
            else
            {
                return $"{_Book} {_Chapter}:{_Verse}";
            }
        }
    }