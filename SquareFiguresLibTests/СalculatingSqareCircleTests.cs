namespace SquareFiguresLibTests
{
    public class ÑalculatingSqareCircleTests
    {
        [Fact]
        public void ÑalculatingSqareRad5()
        {
            double r = 5;
            double square = Math.PI * 5 * 5;

            double actual = Circle.ÑalculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void ÑalculatingSqareRad10()
        {
            double r = 10;
            double square = Math.PI * r * r;

            double actual = Circle.ÑalculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void ÑalculatingSqareRad15()
        {
            double r = 15;
            double square = Math.PI * r * r;

            double actual = Circle.ÑalculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void ÑalculatingSqareRad0()
        {
            double r = 0;
            double square = Math.PI * r * r;

            double actual = Circle.ÑalculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void ÑalculatingSqareSubzero()
        {
            double r = -5;
            double square = double.NaN;

            double actual = Circle.ÑalculatingSqare(r);

            Assert.Equal(square, actual);
        }
    }
}