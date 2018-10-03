using System.Windows;


namespace PDecorator
{
    public partial class MainWindow : Window
    {
        private int _x = 0;
        private int _y = 10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Rect rect = new BlackRect();

            if (Red.IsChecked==true)
                rect = new RedFilling(rect);

            if (Green.IsChecked == true)
                rect = new GreenFilling(rect);

            if (YellowBorder.IsChecked == true)
                rect = new YellowBorder(rect);

            if (BlueBorder.IsChecked == true)
                rect = new BlueBorder(rect);

            if (TwiceLarger.IsChecked == true)
                rect = new TwiceLarger(rect);

            if (TwiceSmaller.IsChecked == true)
                rect = new TwiceSmaller(rect);

            _x += 40;

            if ((_x + 40) > MainCanvas.Width)
            {
                _y += 40;
                _x = 0;
            }

            rect.Draw(MainCanvas, new Point(_x,_y));
        }
    }
}
