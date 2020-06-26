using System;
using System.Threading.Tasks;

namespace TurtleLogic
{
    public class Triangle : IShape
    {
        private readonly double _base;

        public Triangle(double baseLength)
        {
            _base = baseLength;
        }

        public async Task Draw(ITurtle turtle)
        {
            double height = Math.Cos(Math.PI / 6) * _base;
            double centre = _base * Math.Tan(Math.PI / 6) / 2;

            turtle.Up();
            await turtle.Move(0.5 - _base / 2, 0.5 + centre);
            turtle.Down();
            await turtle.Move(0.5 + _base / 2, 0.5 + centre);
            await turtle.Move(0.5, 0.5 + centre - height);
            await turtle.Move(0.5 - _base / 2, 0.5 + centre);
        }
    }
}
