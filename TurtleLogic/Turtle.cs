using System;
using System.Threading;
using System.Threading.Tasks;

namespace TurtleLogic
{
    public class Turtle : IShapeDrawer, ITurtle
    {
        private bool _isDown;
        private (double x, double y) _location;

        public ICanvas Canvas { get; set ; }

        public void Down() => _isDown = true;
        public void Up() => _isDown = false;

        public async Task Move(double x, double y)
        {
            if (_isDown)
                await Task.Run(() => StaggeredDraw(x, y));

            _location = (x, y);
        }

        private void StaggeredDraw(double x, double y)
        {
            double width = x - _location.x;
            double height = y - _location.y;

            const int stepRatio = 30;
            const int stepDelay = 30;

            int steps = (int)(Math.Sqrt(width * width + height * height) * stepRatio);

            if (steps > 0)
            {
                double dx = width / steps;
                double dy = height / steps;

                for (int i = 1; i < steps; ++i)
                {
                    Canvas.DrawSegment(_location.x + (i - 1) * dx, _location.y + (i - 1) * dy, _location.x + i * dx, _location.y + i * dy);
                    Thread.Sleep(stepDelay);
                }

                Canvas.DrawSegment(_location.x + (steps - 1) * dx, _location.y + (steps - 1) * dy, x, y);
                Thread.Sleep(stepDelay);
            }
            else
            {
                Canvas.DrawSegment(_location.x, _location.y, x, y);
                Thread.Sleep(stepDelay);
            }
        }

        public async Task DrawShape(IShape shape)
        {
            await shape.Draw(this);
        }
    }
}
