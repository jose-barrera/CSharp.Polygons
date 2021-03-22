using System;
using System.Drawing;
using System.Collections.Generic;

namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a non intersecting closed polygon.
    /// 
    /// </summary>
    public class Polygon
    {
        #region INTERNAL FIELDS

        protected List<Point> vertices;
        private Color fillColor;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds an empty polygon, it is only for the purpose of inheritance.
        /// 
        /// </summary>
        protected Polygon()
        {
            this.vertices = new List<Point>();
            Random random = new Random();
            this.fillColor = Color.FromArgb(128, random.Next(256), random.Next(256), random.Next(256));
        }

        /// <summary>
        /// 
        /// Build a closed polygon with the points provided.
        /// 
        /// </summary>
        /// <param name="vertices">List of polygon's vertices.</param>
        public Polygon(List<Point> vertices) : this()
        {
            foreach(Point point in vertices)
            {
                this.vertices.Add(point);
            }
        }

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// 
        /// Returns the number of sides of the polygon (READ-ONLY).
        /// 
        /// </summary>
        public int Sides
        {
            get
            {
                return this.vertices.Count;
            }
        }

        /// <summary>
        /// 
        /// Returns an array with the vertices of the polygon converted to PointF objects.
        /// 
        /// </summary>
        public PointF[] Vertices
        {
            get
            {
                PointF[] vertices = new PointF[this.vertices.Count];
                for (int i = 0; i < this.vertices.Count; i++)
                {
                    vertices[i] = new PointF(this.vertices[i].X, this.vertices[i].Y);
                }
                return vertices;
            }
        }

        /// <summary>
        /// 
        /// Returns the value of polygon's perimeter (READ-ONLY).
        /// 
        /// </summary>
        public double Perimeter
        {
            get
            {
                double result = 0;
                int n = this.vertices.Count;
                if (n > 2)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        result += this.vertices[i].DistanceTo(this.vertices[i + 1]);
                    }
                    result += this.vertices[n - 1].DistanceTo(this.vertices[0]);
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// Returns the value of polygon's area (READ-ONLY).
        /// 
        /// </summary>
        public double Area
        {
            get
            {
                double result = 0;
                int n = this.vertices.Count;
                if (n > 2)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        result += (this.vertices[i].X * this.vertices[i + 1].Y - this.vertices[i].Y * this.vertices[i + 1].X);
                    }
                    result += (this.vertices[n - 1].X * this.vertices[0].Y - this.vertices[n - 1].Y * this.vertices[0].X);
                    result = 0.5 * Math.Abs(result);
                }

                return result;
            }
        }

        /// <summary>
        /// 
        /// Returns the centroid of the polygon (READ-ONLY).
        /// 
        /// </summary>
        public virtual Point Centroid
        {
            get
            {
                float x = 0;
                float y = 0;
                float determinant = 0;
                float step = 0;
                Point centroid = null;
                int n = this.vertices.Count;
                if (n > 2)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        step = (this.vertices[i].X * this.vertices[i + 1].Y - this.vertices[i].Y * this.vertices[i + 1].X);
                        determinant += step;
                        x += (this.vertices[i].X + this.vertices[i + 1].X) * step;
                        y += (this.vertices[i].Y + this.vertices[i + 1].Y) * step;
                    }
                    step = (this.vertices[n - 1].X * this.vertices[0].Y - this.vertices[n - 1].Y * this.vertices[0].X);
                    determinant += step;
                    x += (this.vertices[n - 1].X + this.vertices[0].X) * step;
                    y += (this.vertices[n - 1].Y + this.vertices[0].Y) * step;
                    x /= 3 * determinant;
                    y /= 3 * determinant;
                    centroid = new Point(x, y);
                }

                return centroid;
            }
        }

        /// <summary>
        /// 
        /// Returns the color to fill the polygon.
        /// 
        /// </summary>
        public Color FillColor
        {
            get
            {
                return this.fillColor;
            }
        }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// 
        /// Returns a specific vertex of the polygon.
        /// 
        /// </summary>
        /// <param name="index">Index of vertex.</param>
        /// <returns></returns>
        public Point Vertex(int index)
        {
            return this.vertices[index];
        }

        /// <summary>
        /// 
        /// Moves the polygon to another position.
        /// 
        /// </summary>
        /// <param name="dx">Horizontal displacement.</param>
        /// <param name="dy">Vertical displacement.</param>
        public void Translate(int dx, int dy)
        {
            foreach(Point point in this.vertices)
            {
                point.Translate(dx, dy);
            }
        }

        /// <summary>
        /// 
        /// Rotates the polygon around its centroid.
        /// 
        /// </summary>
        /// <param name="theta">Rotation angle.</param>
        public void Rotate(float theta)
        {
            foreach (Point point in this.vertices)
            {
                point.Rotate(Centroid, theta);
            }
        }

        #endregion
    }
}
