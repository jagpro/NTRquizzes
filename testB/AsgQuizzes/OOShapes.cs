using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgQuizzes
{
    public class OOShapes
    {
        List<IShape> shapes = new List<IShape>();

        public IEnumerable<IShape> AllShapes
        {
            get { return shapes; }
        }

        public void AddTriangle(double height, double width)
        {
            shapes.Add(new Shape("Triangle", 0.5 * height * width));
        }

        public void AddRectangle(double height, double width)
        {
            shapes.Add(new Shape("Rectangle", height * width));
        }

        public string PrintAll()
        {
            StringBuilder result = new StringBuilder();

            shapes.ForEach(x => {
                switch (x.WhatIAm)
                {
                    case "Rectangle": 
                        result.AppendFormat("||{0}",Convert.ToInt16(x.Area));
                        break;
                    case "Triangle":
                        result.AppendFormat("/\\{0}", Convert.ToInt16(x.Area));
                        break;
                }
            });

            return result.ToString();
        }

    }

    /// <summary>
    /// HINT: You are expected to write classes that implement this interface
    /// </summary>
    public interface IShape
    {
        string WhatIAm { get; }
        double Area { get; }
    }

    public class Shape: IShape
    {
        private string whatIam;
        private double area;

        public Shape(string whatIam, double area)
        {
            this.whatIam = whatIam;
            this.area = area;
        }

        public string WhatIAm
        {
            get { return whatIam; }
        }

        public double Area
        {
            get { return area; }
        }
    }
}