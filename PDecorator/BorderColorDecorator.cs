using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PDecorator
{
    public class YellowBorder : Decorator
    {
        public YellowBorder(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Stroke = Brushes.Yellow;
            base.Draw(canvas, point);
        }
    }

    public class BlueBorder : Decorator
    {
        public BlueBorder(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Stroke = Brushes.Blue;
            base.Draw(canvas, point);
        }
    }
}
