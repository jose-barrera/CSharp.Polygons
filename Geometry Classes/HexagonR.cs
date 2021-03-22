namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular hexagon.
    /// 
    /// </summary>
    class HexagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular hexagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the hexagon.</param>
        /// <param name="vertex">First vertex of the hexagon.</param>
        public HexagonR(Point center, Point vertex) : base(center, vertex, 6)
        {
        }

        #endregion
    }
}
