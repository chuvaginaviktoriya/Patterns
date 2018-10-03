
using System.Windows;
using System.Windows.Controls;

namespace PDecorator
{
    public abstract class Decorator : Rect
    {
        public Rect rect;

        public Decorator(Rect rect) : base()
        {
            this.rect = rect;
            ExistingRectangle = rect.ExistingRectangle;
        }

        public override void Draw(Canvas canvas, Point point)
        {
            rect.Draw(canvas, point);
        }
    }
}
