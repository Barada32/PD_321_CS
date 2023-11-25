using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	class Rectangle : Shape, IHaveDiagonal
	{

		double width;
		double height;
		public double Width
		{
			get { return width; }
			set
			{
				if (value < MIN_LENGTH) value = MIN_LENGTH;
				if (value > MAX_LENGTH) value = MAX_LENGTH;
				width = value;
			}
		}
		public double Height//kjhkhjkkhkhjkj
		{
			get { return height; }
			set
			{
				if (value < MIN_LENGTH) value = MIN_LENGTH;
				if (value > MAX_LENGTH) value = MAX_LENGTH;
				height = value;
			}
		}

		public Rectangle
			(
			int width, int height,
			int start_x, int start_y, int line_width, Color color
			) : base(start_x, start_y, line_width, color)
		{
			Width = width;
			Height = height;
		}

		public override double GetArea()
		{
			return Width * Height;
		}
		public override double GetPerimeter()
		{
			return (Width + Height) * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Height);
			DrawDiagonal(e);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Высота: {Height}");
			Console.WriteLine($"Диагональ: {GetDiagonal()}");
			base.Info(e);
		}
		public double GetDiagonal()
		{
			return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
		}
		public void DrawDiagonal(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, 1);
			e.Graphics.DrawLine(pen, StartX, StartY, StartX + (float)Width, StartY + (float)Height);
		}
	}
}

/*
----------------------
IMoveable - этот интерфейс показывает, что объект умеет двигаться.
			Даный интерфейс реализую такие классы как: Human, Car, Animal, Insect.....
IFlyable - этот интерфейс показывает, что объект умеет летать.
		   Его реализуют такие классы как: Plain, Helicopter, Bird, Insect.......
IHaveDiagonal - показывает, что у объектов есть диагональ.
				Этот интерфей реализую такие классы как: Square, Rectangle
IHaveRadius - показывает, что у объектов есть радиус.
----------------------
 */