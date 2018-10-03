using System.Windows;
using System.Windows.Controls;

namespace PDecorator
{
    public class TwiceLarger : Decorator
    {
        public TwiceLarger(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Width *= 2;
            rect.ExistingRectangle.Height *= 2;
            base.Draw(canvas, point);
        }
    }

    public class TwiceSmaller : Decorator
    {
        public TwiceSmaller(Rect rect) : base(rect)
        {
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.ExistingRectangle.Width /= 2;
            rect.ExistingRectangle.Height /= 2;
            base.Draw(canvas, point);
        }
    }
}
