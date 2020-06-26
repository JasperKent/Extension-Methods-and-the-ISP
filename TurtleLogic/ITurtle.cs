using System.Threading.Tasks;

namespace TurtleLogic
{
    public interface ITurtle : IDrawer
    {
        void Up();
        void Down();
        Task Move(double x, double y);
    }
}
