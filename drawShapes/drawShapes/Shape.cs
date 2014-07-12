using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace drawShapes
{

    public abstract class Shape
    {
        private Canvas _canvas;
        protected System.Windows.Shapes.Shape _element;
        static Random _rand = new Random();

        public Shape (Canvas canvas)
	    {
            _canvas = canvas;
	    }
        
        public virtual void Draw()
        {
            double left = _canvas.ActualWidth * _rand.NextDouble();
            double top = _canvas.ActualHeight * _rand.NextDouble();

            _element.SetValue(Canvas.LeftProperty, left);
            _element.SetValue(Canvas.TopProperty, top);

            _canvas.Children.Add(_element);
        }
    }

    public class Square : Shape
    {
        public Square(Canvas canvas) 
            :base(canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 10;
            rect.Fill = new SolidColorBrush(Colors.Green);
            rect.Stroke = new SolidColorBrush(Colors.Black);

            _element = rect;
        }

        public override void Draw()
        {
            // change stuff for squares
            _element.Fill = new SolidColorBrush(Colors.Orange);
            base.Draw();
        }
    }

    public class Circle : Shape
    {
        public Circle(Canvas canvas) 
            :base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.Fill = new SolidColorBrush(Colors.Aqua);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);

            _element = ellipse;
        }

        public override void Draw()
        {
            // change stuff for circles
            base.Draw();
        }
    }

    public struct Complex
    {
        public int Real;
        public int Imaginary;

    }
}
