namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular dodecagon.
    /// 
    /// </summary>
    class DodecagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular dodecagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the dodecagon.</param>
        /// <param name="vertex">First vertex of the dodecagon.</param>
        public DodecagonR(Point center, Point vertex) : base(center, vertex, 12)
        {
        }

        #endregion
    }
}
