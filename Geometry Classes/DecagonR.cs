namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular decagon.
    /// 
    /// </summary>
    class DecagonR : PolygonR
    {
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular decagon using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the decagon.</param>
        /// <param name="vertex">First vertex of the decagon.</param>
        public DecagonR(Point center, Point vertex) : base(center, vertex, 10)
        {
        }

        #endregion
    }
}
