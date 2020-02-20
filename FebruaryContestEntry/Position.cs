namespace FebruaryContestEntry
{
    public class Position
    {
        private int xPosition;

        public int Row
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        private int yPosition;

        public int Column
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

        public Character Character { get; set; }

        public Position(int xPosition, int yPosition, Character character = null)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            if (character == null)
            {
                this.Character = new Character(ForeColor.Available, character.Char);
            }
            else
            {
                this.Character = character;
            }
        }
    }
}