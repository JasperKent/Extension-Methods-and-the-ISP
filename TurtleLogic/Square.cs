using System.Threading.Tasks;

namespace TurtleLogic
{
    public class Square : IShape
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public async Task Draw(ITurtle turtle)
        {
            turtle.Up();
            await turtle.Move(0.5 - _side / 2, 0.5 - _side / 2);
            turtle.Down();
            await turtle.Move(0.5 - _side / 2, 0.5 + _side / 2);
            await turtle.Move(0.5 + _side / 2, 0.5 + _side / 2);
            await turtle.Move(0.5 + _side / 2, 0.5 - _side / 2);
            await turtle.Move(0.5 - _side / 2, 0.5 - _side / 2);
        }
    }
}
