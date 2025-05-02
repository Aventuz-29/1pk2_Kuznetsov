using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33_01
{
    class Rectangle : IDrawable
    {
        //самостоятельно прописатьтреугольник и его логику рисования в консоли
        //для упрощения  - прямугольный треугольник
        private int height;

        public int Height
        {
            get => height;
            set
            {
                if (value > 1)
                    height = value;
                else
                    throw new ArgumentException("высота не должна быть меньше или равна 1");
            }
        }
        public Rectangle(int height)
        {
            Height = height;
        }
        public void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
