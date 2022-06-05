//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.05.2022

using System;
using System.Drawing;

public class Triangle : Figure
{
    public Point FirstPoint
    {
        get { return basePoint; }
        set { basePoint = value; }
    }
    public Point SecondPoint { get; set; }
    public Point ThirdPoint { get; set; }
                                                                                    
    public Triangle(int x1, int y1, int x2, int y2, 
        int x3, int y3, float width, Color color) : base(x1, y1, width, color)
    {
        SecondPoint = new Point(x2, y2);
        ThirdPoint = new Point(x3, y3);
    }

    public Triangle(Point point1, Point point2, Point point3, 
        float width, Color color) : base(point1, width, color)
    {
        SecondPoint = point2;
        ThirdPoint = point3;
    }                                                                                  

    public override string GetInfOfFigure()
    {
        return $"{this.ToString()} {FirstPoint.X} {FirstPoint.Y} " +
            $"{SecondPoint.X} {SecondPoint.Y} {ThirdPoint.X} {ThirdPoint.Y} " +
            $"{stroke.Width} {stroke.Color}";
    }

    public override void Draw(Graphics paper)
    {
        paper.DrawPolygon(new Pen(stroke.Color, stroke.Width), 
            new Point[] { FirstPoint, SecondPoint, ThirdPoint });
    }
}
