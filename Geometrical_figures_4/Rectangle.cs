//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.04.2022

using System;
using System.Drawing;

public class Rectangle : Figure
{
	public Point LowerLeftPoint
	{
		get { return basePoint; }
		set { basePoint = value; }
	}
	public Point UpperRightPoint { get; set; }

	public Rectangle(int x1, int y1, int x2, int y2, 
		float width, Color color) : base(x1, y1, width, color)
	{
		UpperRightPoint = new Point(x2, y2);
	}

	public Rectangle(Point point1, Point point2, 
		float width, Color color) : base(point1, width, color)
	{
		UpperRightPoint = point2;
	}

	public override string GetInfOfFigure()
	{
		return $"{this.ToString()} {LowerLeftPoint.X} {LowerLeftPoint.Y} " +
			$"{UpperRightPoint.X} {UpperRightPoint.Y} {stroke.Width} {stroke.Color}";
	}

	public override void Draw(Graphics paper)
    {
		paper.DrawRectangle(new Pen(stroke.Color, stroke.Width), LowerLeftPoint.X, LowerLeftPoint.Y, 
			UpperRightPoint.X - LowerLeftPoint.X, UpperRightPoint.Y - LowerLeftPoint.Y);
    }
}
