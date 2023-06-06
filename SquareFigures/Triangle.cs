using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigures
{
    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        // создание треугольника с определёнными сторонами
        public Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                if(sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideB + sideA || sideA < 0 || sideB < 0 || sideC < 0)
                    throw new Exception("these are not the sides of a triangle");
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;    
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
        }
        // изменение стороны треугольника 
        public double sideA
        {
            set
            {
                try
                {
                    if (value > _sideB + _sideC || _sideB > value + _sideC || _sideC > _sideB + value || value < 0 || _sideB < 0 || _sideC < 0)
                        throw new Exception("these are not the sides of a triangle");
                    _sideA = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error: {e.Message}");
                }
            }
            get { return _sideA; }
        }
        // изменение стороны треугольника 
        public double sideB
        {
            set
            {
                try
                {
                    if (_sideA > value + _sideC || value > _sideA + _sideC || _sideC > value + _sideA || _sideA < 0 || value < 0 || _sideC < 0)
                        throw new Exception("these are not the sides of a triangle");
                    _sideB = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error: {e.Message}");
                }
            }
            get { return _sideB; }
        }
        // изменение стороны треугольника 
        public double sideC
        {
            set
            {
                try
                {
                    if (_sideA > _sideB + value || _sideB > _sideA + value || value > _sideB + _sideA || _sideA < 0 || _sideB < 0 || value < 0)
                        throw new Exception("these are not the sides of a triangle");
                    _sideC = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"error: {e.Message}");
                }
            }
            get { return _sideC; }
        }
        // расчёт площади треугольника
        public double Square
        {
            get 
            {
                double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
                return  Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
            }
        }
        // проверка на прямоугольный треугольник
        public bool isRightTriangle 
        {
            get
            {
                if (_sideA > _sideB && _sideA > _sideC)
                    return _sideA * _sideA == _sideB * sideB + _sideC * _sideC;
                if (_sideB > _sideA && _sideB > _sideC)
                    return _sideB * _sideB == _sideA * sideA + _sideC * _sideC;
                if (_sideC > _sideB && _sideC > _sideA)
                    return _sideC * _sideC == _sideB * sideB + _sideA * _sideA;
                return false;
            }
        }
        // проверка на прямоугольный треугольника по 3 сторонам 
        static public bool CheckingTheRightTriangle(double sideA, double sideB, double sideC)
        {
            try
            {
                if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideB + sideA || sideA < 0 || sideB < 0 || sideC < 0)
                    throw new Exception("these are not the sides of a triangle");
                if (sideA > sideB && sideA > sideC)
                return sideA * sideA == sideB * sideB + sideC * sideC;
                if (sideB > sideA && sideB > sideC)
                    return sideB * sideB == sideA * sideA + sideC * sideC;
                if (sideC > sideB && sideC > sideA)
                    return sideC * sideC == sideB * sideB + sideA * sideA;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
            return false;
        }

        // расчёт площади треугольника по 3 сторонам 
        static public double СalculatingSqare(double sideA, double sideB, double sideC)
        {
            try
            {
                if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideB + sideA || sideA < 0 || sideB < 0 || sideC < 0)
                    throw new Exception("these are not the sides of a triangle");
                double halfPerimeter = (sideA + sideB + sideC) / 2;
                return  Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
            return double.NaN;
        }
    }
}
