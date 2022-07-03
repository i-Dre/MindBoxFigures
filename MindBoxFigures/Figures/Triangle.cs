using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled { get => CheckIsRightAngled(); }

        /// <summary>
        /// Свойства для хранения значений сторон треугольника
        /// </summary>
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Конструктор экземпляра для заполнения сторон треугольника
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <exception>Если одна из сторон меньше 0<exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > 0 && sideB > 0 && sideC > 0)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else 
                throw new ArgumentException("Одна из сторон меньше или равна 0");
        }

        /// <summary>
        /// Переопределение абстрактного метода GetSquare (Получение площади)
        /// </summary>
        /// <returns>Площадь треугольника по формуле Герона</returns>
        protected override double GetSquare()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2.0;
            return Math.Sqrt(
                semiPerimeter
                * (semiPerimeter - SideA)
                * (semiPerimeter - SideB)
                * (semiPerimeter - SideC)
            );
        }
        /// <summary>
        /// Проверка на наличие прямого угла
        /// с^2 = a^2 + b^2 (Пифагор), где с - наибольшая сторона
        /// </summary>
        /// <returns> True - прямоугольный, False - нет</returns>
        private bool CheckIsRightAngled()
        {
            var sideArray = new double[] { SideA, SideB, SideC };
            Array.Sort(sideArray); 
            Array.Reverse(sideArray);
            return Math.Pow(sideArray[0], 2) == Math.Pow(sideArray[1], 2) + Math.Pow(sideArray[2], 2);
        }
    }
}
