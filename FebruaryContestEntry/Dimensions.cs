namespace FebruaryContestEntry
{
    public class Dimensions
    {
        private int columns;

        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        private int rows;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }



        public Dimensions(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
    }
}