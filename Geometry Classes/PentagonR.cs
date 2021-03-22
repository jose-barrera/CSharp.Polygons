namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular pentagon.
    /// 
    /// </summary>
    class PentagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular pentagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the pentagon.</param>
        /// <param name="vertex">First vertex of the pentagon.</param>
        public PentagonR(Point center, Point vertex) : base(center, vertex, 5)
        {
        }

        #endregion
    }
}
