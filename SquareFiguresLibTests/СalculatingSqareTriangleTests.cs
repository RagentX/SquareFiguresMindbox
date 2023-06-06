namespace SquareFiguresLibTests
{
    public class СalculatingSqareTriangleTests
    {
        [Fact]
        public void SquareA3B4C5()
        {
            double a = 3, b = 4, c = 5;
            double square = 6;

            double actual = Triangle.СalculatingSqare(a, b, c);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void SquareA3B4C8()
        {
            double a = 3, b = 4, c = 8;
            double square = double.NaN;

            double actual = Triangle.СalculatingSqare(a, b, c);
            Assert.Equal(square, actual);
        }

    }
}
