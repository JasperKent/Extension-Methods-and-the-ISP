using System.Threading.Tasks;

namespace TurtleLogic
{
    public interface IShapeDrawer : IDrawer
    {
        Task DrawShape(IShape shape);
    }
}
