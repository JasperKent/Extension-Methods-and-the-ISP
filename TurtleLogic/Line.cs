using System.Threading.Tasks;

namespace TurtleLogic
{
    public class Line : IShape
    {
        public async Task Draw(ITurtle turtle)
        {
            turtle.Up();
            await turtle.Move(0.2, 0.5);
            turtle.Down();
            await turtle.Move(0.8, 0.5);
        }
    }
}
