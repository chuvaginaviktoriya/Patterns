using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PDecorator
{

    public class GreenFilling : Decorator
    {
        public GreenFilling(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Fill = Brushes.Green;
            base.Draw(canvas, point);
        }

    }

    public class RedFilling : Decorator
    {
        public RedFilling(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Fill = Brushes.Red;
            base.Draw(canvas, point);

        }
    }

}
