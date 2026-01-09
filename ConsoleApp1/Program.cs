using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IShape
    {
        void Draw();
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I will Draw square.");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I will Draw circle.");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I will Draw rectangle.");
        }
    }

    public class ShapeMakerFacade
    {
        private IShape _circle;
        private IShape _square;
        private IShape _rectangle;

        public ShapeMakerFacade()
        {
            _circle = new Circle();
            _square = new Square();
            _rectangle = new Rectangle();
        }

        public void DrawCircle() => _circle.Draw();
        public void DrawSquare() => _square.Draw();
        public void DrawRectangle() => _rectangle.Draw();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeMakerFacade ShapeMakerFacade = new ShapeMakerFacade();
            ShapeMakerFacade.DrawCircle();
            ShapeMakerFacade.DrawSquare();
            ShapeMakerFacade.DrawRectangle();

            Console.ReadLine();
        }
    }
}
