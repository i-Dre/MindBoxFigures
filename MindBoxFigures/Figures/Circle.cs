using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Свойство для хранения значения радиуса
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор экземпляра для заполнения радиуса
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
                throw new ArgumentException("Радиус меньше или равен 0");
        }

        /// <summary>
        /// Переопределение абстрактного метода GetSquare (Получение площади)
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected sealed override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
