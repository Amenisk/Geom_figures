//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.04.2022

using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

static public class Figures
{
	static private List<Figure> figures = new List<Figure>();

	static public void Add(Figure figure)
    {
			figures.Add(figure);
    }

	static public void Load(string path)
    {
		using (var reader = new StreamReader(path))
		{
			string s;
			string[] data;
			int[] coords;
			while ((s = reader.ReadLine()) != null)
			{
				data = s.Split();
				coords = SelectValues(data);

				switch (data[0])
				{
					case "Segment":
						figures.Add(new
							Segment(coords[0], coords[1],
							coords[2], coords[3], GetWidth(data), GetColor(data)));
						break;
																					
					case "Rectangle":
						figures.Add(new
							Rectangle(coords[0], coords[1],
							coords[2], coords[3], GetWidth(data), GetColor(data)));
						break;

					case "Triangle":
						figures.Add(new
							Triangle(coords[0], coords[1],
							coords[2], coords[3],
							coords[4], coords[5],
							GetWidth(data), GetColor(data)));
						break;

					case "Circle":
						figures.Add(new
							Circle(coords[0], coords[1],
							coords[2], coords[3],
							GetWidth(data), GetColor(data)));
						break;

					default:
						throw new Exception("Figure not found or file is corrupted");
				}
			}
		}
	}

	static public void Save(string path)
    {
		using (var writer = new StreamWriter(path))
		{ 
			foreach (var f in figures)
            {
				writer.WriteLine(f.GetInfOfFigure());
            }
		}
	}

	static public void Draw(Graphics paper)
    {
		foreach (var f in figures)
        {
			f.Draw(paper);
		}
    }

	static private int[] SelectValues(string[] data)
	{
		var values = new int[data.Length - 4];

		for (var i = 1; i < data.Length - 3; ++i)
		{
			values[i - 1] = int.Parse(data[i]);
		}

		return values;
	}

	static public Color GetColor(string[] data)
    {
		return Color.FromName(data[data.Length - 1].Substring(1, data[data.Length - 1].Length - 2));
    }

	static public float GetWidth(string[] data)
	{
		return float.Parse(data[data.Length - 3]);
	}

	static public void Clear()
    {
		figures.Clear();
    }

	static public List<Figure> GetFigures()
    {
		return figures;
    }
}
