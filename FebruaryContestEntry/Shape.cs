using System;

namespace FebruaryContestEntry
{
    public class Shape
    {
        private Dimensions dimensions;
        public int Columns { get; internal set; }
        public int Rows { get; internal set; }
        public Character character { get; set; }

        public Position[,] Positions;

        public Shape(Dimensions dimensions, Character character)
        {
            this.dimensions = dimensions;
            Columns = dimensions.Columns;
            Rows = dimensions.Rows;
            this.Positions = new Position[Rows, Columns];
            this.character = character;
            InitPositions(character);
        }

        public Shape Render()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    var @char = GetCharacterAtPosition(row, col);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), @char.ForeColor.ToString());
                    Console.Write(@char.Char);
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            return this;
        }

        private void InitPositions(Character @char)
        {
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    Positions[r, c] = new Position(r, c, @char);
                    Positions[r, c].Character =  @char;
                }
            }
        }

        public void FillAllWithCharacter(Character character)
        {
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    Positions[r, c].Character = character;
                }
            }
        }

        public Character GetCharacterAtPosition(int row, int column)
        {
            return (row < Rows && column < Columns) ? Positions[row, column].Character : null;
        }

        public Shape Border(Character character)
        {
            /*
             * Border has four sides
             * topside is from row=0 to all column=0..Columns
             * leftside is from column=0 to all row=0..Rows
             * rightside is from column=Columns.number to all row=0..Rows
             * bottomside is from row=Rows.number to all column=0..Columns 
             * 
             * */

            //topside
            this.PopulateBorderTop(character);
            //leftside
            this.PopulateBorderLeft(character);
            //rigthside
            this.PopulateBorderRight(character);
            //bottomside
            this.PopulateBorderBottom(character);

            return this;
        }

        private void PopulateBorderBottom(Character character)
        {
            for (int c = 0; c < Columns; c++)
            {
                Positions[Rows - 1, c].Character = character;
            }
        }

        private void PopulateBorderRight(Character character)
        {
            for (int r = 0; r < Rows; r++)
            {
                Positions[r, Columns - 1].Character = character;
            }
        }

        private void PopulateBorderLeft(Character character)
        {
            for (int i = 0; i < Rows; i++)
            {
                Positions[i, 0].Character = character;
            }
        }

        private void PopulateBorderTop(Character character)
        {
            for (int i = 0; i < Columns; i++)
            {
                Positions[0, i].Character = character;
            }
        }
    }
}