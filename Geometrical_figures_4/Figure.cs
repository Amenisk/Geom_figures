//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.05.2022

using System;
using System.Drawing;

public class Figure
{
    public struct StrokeData
    {
        public float Width;
        public Color Color;
    }

    public struct FillData
    {
        public int Color;
    }

    protected Point basePoint;
    protected StrokeData stroke;

    public Figure(int x, int y, float width, Color color)
    {
        basePoint = new Point(x, y);
        stroke.Width = width;
        stroke.Color = color;
    }

    public Figure(Point point, float width, Color color)
    {
        basePoint = point;
        stroke.Width = width;
        stroke.Color = color;
    }

    public virtual void Draw(Graphics paper)
    {
    }

    public virtual string GetInfOfFigure()
    {
        return null;
    }
}
