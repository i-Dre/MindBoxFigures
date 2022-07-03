using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures
{
    public abstract class Figure
    {   

        protected double _square;

        /// <summary>
        /// Переменная для обозначения измененности общих свойств
        /// True - изменений 
        /// </summary>
        private bool isChange = true;

        /// <summary>
        /// Свойство для хранения значения площади
        /// </summary>
        public double Square
        {
            get
            {
                if (isChange)
                {
                    isChange = false;
                    return _square = GetSquare();
                }
                else return _square;
            }
        }

        /// <summary>
        /// Метод для вычисления площади фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double GetSquare(); 
    }
}
