namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular heptagon.
    /// 
    /// </summary>
    class HeptagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular heptagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the heptagon.</param>
        /// <param name="vertex">First vertex of the heptagon.</param>
        public HeptagonR(Point center, Point vertex) : base(center, vertex, 7)
        {
        }

        #endregion
    }
}
