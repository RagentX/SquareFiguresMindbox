using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigures
{
    public class Circle
    {
        private double _radius;
        private double _square;


        // создание пустого круга
        public Circle()
        {
            _radius = 0;
            _square = 0;
        }
        // перегрузка для создание круга определённого радиуса
        public Circle(double radius)
        {
            try
            {
                if (radius < 0)
                    throw new Exception("the radius cannot be subzero");
                _radius = radius;
                _square = Math.PI * _radius * _radius;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
        }
        // блок для изменения радиуса круга
        public double Radius
        { 
            get { return _radius;} 
            set 
            {
                try
                {
                    if (value < 0)
                        throw new Exception("the radius cannot be subzero");
                    _radius = value;
                    _square = Math.PI * value * value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error: {e.Message}");
                }
            }
        }
        // блок для возврата площади
        public double Square
        {
            get { return _square; }
        }

        // функция для вычисления площади по радиусу
        static public double СalculatingSqare(double radius)
        {
            try
            {
                if (radius < 0)
                    throw new Exception("the radius cannot be subzero");
                return Math.PI * radius * radius;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
            return double.NaN;
        }
    }
}
