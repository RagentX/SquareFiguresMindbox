namespace SquareFiguresLibTests
{
    public class �alculatingSqareCircleTests
    {
        [Fact]
        public void �alculatingSqareRad5()
        {
            double r = 5;
            double square = Math.PI * 5 * 5;

            double actual = Circle.�alculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void �alculatingSqareRad10()
        {
            double r = 10;
            double square = Math.PI * r * r;

            double actual = Circle.�alculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void �alculatingSqareRad15()
        {
            double r = 15;
            double square = Math.PI * r * r;

            double actual = Circle.�alculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void �alculatingSqareRad0()
        {
            double r = 0;
            double square = Math.PI * r * r;

            double actual = Circle.�alculatingSqare(r);
            Assert.Equal(square, actual);
        }

        [Fact]
        public void �alculatingSqareSubzero()
        {
            double r = -5;
            double square = double.NaN;

            double actual = Circle.�alculatingSqare(r);

            Assert.Equal(square, actual);
        }
    }
}