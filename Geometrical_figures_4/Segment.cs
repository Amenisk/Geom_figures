//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.05.2022

using System;
using System.Drawing;

public class Segment : Figure
{
	public Point FirstPoint 
	{
		get { return basePoint; }
		set { basePoint = value; }
	}
	public Point SecondPoint { get; set; }

	public Segment(int x1, int y1, int x2, int y2, float width, 
		Color color) : base(x1, y1, width, color)
	{
		SecondPoint = new Point(x2, y2);
	}
																																																	
	public Segment(Point point1, Point point2, float width, 
		Color color) : base(point1, width, color)
	{
		SecondPoint = point2;
	}

	public override string GetInfOfFigure()
    {
		return $"{this.ToString()} {FirstPoint.X} {FirstPoint.Y} " +
			$"{SecondPoint.X} {SecondPoint.Y} {stroke.Width} {stroke.Color}";
    }

    public override void Draw(Graphics paper)
    {
		paper.DrawLine(new Pen(stroke.Color, stroke.Width), FirstPoint, SecondPoint);
    }


}
