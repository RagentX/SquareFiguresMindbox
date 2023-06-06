namespace SquareFiguresLibTests
{
    public class CheckingTheRightTriangleTests
    {
        [Fact]
        public void CheckingTheRightTriangleA3B4C5()
        {
            double a = 3, b = 4, c = 5;
            bool square = true;

            bool actual = Triangle.CheckingTheRightTriangle(a, b, c);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void CheckingTheRightTriangleA3B4C6()
        {
            double a = 3, b = 4, c = 6;
            bool square = false;

            bool actual = Triangle.CheckingTheRightTriangle(a, b, c);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void CheckingTheRightTriangleA3B4C10()
        {
            double a = 3, b = 4, c = 10;
            bool square = false;

            bool actual = Triangle.CheckingTheRightTriangle(a, b, c);
            Assert.Equal(square, actual);
        }
    }
}
