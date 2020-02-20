using FebruaryContestEntry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FCETests
{
    [TestClass]
    public class UnitTest1
    {
        const char block = '▓';

        [TestMethod]
        public void TestMethod1()
        {
        }



        /*
         * Challenge
            Use a console application to draw 

            a shape that is 30 columns wide and 15 rows tall (looks like a square, X=30 Y=15) 

            in the console window. 

            The shape border should be green, 
            and the inside should be yellow. 

            The building block is defined as a constant, 
            and it should be used to draw the shape. 

            The copy-paste of the entire string is prohibited, 

            and it must be drawn using loops, conditions and/or LINQ.
         * */


        [TestMethod]
        public void TestUnitTest1()
        {
            Character character = new Character(ForeColor.Yellow, block);
        }


        [TestMethod]
        public void TestShouldPopulateBoard()
        {
            int columns = 30;
            int rows = 15;
            Dimensions dimensions = new Dimensions(rows, columns);
            Character character = new Character(ForeColor.Yellow, block);
            Shape shape = new Shape(dimensions, character);
            shape.FillAllWithCharacter(character);
            int xPosition = 0;
            int yPosition = 0;
            Assert.AreEqual(character, shape.GetCharacterAtPosition(xPosition, yPosition));
        }

        /// <summary>
        /// The shape border should be green, 
        /// and the inside should be yellow.
        /// </summary>
        [TestMethod]
        public void TestShapeHasBorder()
        {
            int columns = 30;
            int rows = 15;
            Dimensions dimensions = new Dimensions(rows, columns);
            Character yellowCharacter = new Character(ForeColor.Yellow, block);
            Shape shape = new Shape(dimensions, yellowCharacter);

            Character greenCharacter = new Character(ForeColor.Green, block);
            shape.Border(greenCharacter);

            //check center-ish
            Assert.AreEqual(yellowCharacter, shape.GetCharacterAtPosition(1, 1));
            Assert.AreEqual(yellowCharacter, shape.GetCharacterAtPosition(5, 5));

            //check all four corners
            Assert.AreEqual(greenCharacter, shape.GetCharacterAtPosition(0, 0));
            Assert.AreEqual(greenCharacter, shape.GetCharacterAtPosition(rows -1, 0));
            Assert.AreEqual(greenCharacter, shape.GetCharacterAtPosition(0, columns -1));
            Assert.AreEqual(greenCharacter, shape.GetCharacterAtPosition(rows -1, columns - 1));

        }
    }
}
