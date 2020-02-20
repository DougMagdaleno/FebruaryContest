namespace FebruaryContestEntry
{
    public class Character
    {
        private ForeColor foreColor;

        public ForeColor ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public Character(ForeColor foreColor, char character)
        {
            this.foreColor = foreColor;
            this.character = character;
        }

        private char character;

        public char Char
        {
            get { return character; }
            set { character = value; }
        }

    }
}