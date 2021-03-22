namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a square.
    /// 
    /// </summary>
    class Square : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a square using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the square.</param>
        /// <param name="vertex">First vertex of the square.</param>
        public Square(Point center, Point vertex) : base(center, vertex, 4)
        {
        }

        #endregion
    }
}
