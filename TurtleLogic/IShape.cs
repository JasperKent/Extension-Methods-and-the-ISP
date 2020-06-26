using System.Threading.Tasks;

namespace TurtleLogic
{
    public interface IShape
    {
        Task Draw(ITurtle turtle);
    }
}
