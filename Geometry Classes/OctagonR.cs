namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular octagon.
    /// 
    /// </summary>
    class OctagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular octagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the octagon.</param>
        /// <param name="vertex">First vertex of the octagon.</param>
        public OctagonR(Point center, Point vertex) : base(center, vertex, 8)
        {
        }

        #endregion
    }
}
