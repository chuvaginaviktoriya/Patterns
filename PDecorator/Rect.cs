using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PDecorator
{
    public abstract class Rect
    {
        public Rectangle ExistingRectangle;

        public Rect()
        {
            ExistingRectangle = new Rectangle
            {
                Width = 18,
                Height = 18,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
        }

        public virtual void Draw(Canvas canvas, Point point)
        {
            Canvas.SetLeft(ExistingRectangle, point.X);
            Canvas.SetTop(ExistingRectangle, point.Y);
            canvas.Children.Add(ExistingRectangle);
       }
    }

    public class BlackRect: Rect
    {
        public BlackRect(): base()
        {         
        }

    }
   
}

