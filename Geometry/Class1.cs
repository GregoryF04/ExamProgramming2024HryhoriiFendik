namespace Geometry
{
    public interface IReflectable
    {
        void ReflectX();
        void ReflectY();
    }
    public class Point : IReflectable
    {
        private decimal _x;
        private decimal _y;

        public enum PointColour
        {
            Red,
            Green,
            Blue
        }

        public decimal X => _x;
        public decimal Y => _y;
        public Point(decimal x)
        {
            _x = x;
            _y = 0;
        }

        public Point(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        public void ReflectX() => _x = -_x;
        public void ReflectY() => _y = -_y;
    }
}