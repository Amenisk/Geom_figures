//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.04.2022

using System;
using System.Drawing;

public class Circle : Figure
{
	public Point Center
	{
		get { return basePoint; }
		set { basePoint = value; }
	}
	public Point Point { get; set; } //a point on the edge of a circle
	public double Radius { get; set; }

	public Circle(int x1, int y1, int x2, int y2, 
		float width, Color color) : base(x1, y1, width, color)
	{
		Point = new Point(x2, y2);
	}

	public Circle(Point point1, Point point2, 
		float width, Color color) : base(point1, width, color)
	{
		Point = point2;
	}

	protected double GetRadius(int x1, int y1, int x2, int y2)
    {
		return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
	}

	public override string GetInfOfFigure()
	{
		return $"{this.ToString()} {Center.X} {Center.Y} " +
			$"{Point.X} {Point.Y} {stroke.Width} {stroke.Color}";
	}

    public override void Draw(Graphics paper)
    {
		paper.DrawEllipse(new Pen(stroke.Color, stroke.Width), Center.X, Center.Y, 
			Math.Abs(Center.X - Point.X), Math.Abs(Center.X - Point.X));
    }
}
