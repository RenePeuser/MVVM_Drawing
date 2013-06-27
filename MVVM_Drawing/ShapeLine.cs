using System.Windows;

namespace MVVM_Drawing
{
    public class ShapeLine
    {
        public ShapeLine(Point startPoint, Point endPoint)
        {
            Start = startPoint;
            End = endPoint;
        }

        public Point Start { get; private set; }

        public Point End { get; private set; }
    }
}
