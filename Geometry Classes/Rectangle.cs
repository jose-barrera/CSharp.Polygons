namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a rectangle.
    /// 
    /// </summary>
    class Rectangle : Polygon
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a rectangle using two points that represents its diagonal.
        /// 
        /// </summary>
        /// <param name="A">Paint A of the diagonal.</param>
        /// <param name="B">Paint B of the diagonal.</param>
        public Rectangle(Point A, Point B)
        {
            this.vertices.Add(A);
            this.vertices.Add(new Point(A.X, B.Y));
            this.vertices.Add(B);
            this.vertices.Add(new Point(B.X, A.Y));
        }

        #endregion
    }
}
