using System;

namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a regular polygon of n sides.
    /// 
    /// </summary>
    class PolygonR : Polygon
    {
        #region INTERNAL FIELDS

        private Point centroid;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds a regular polygon of n sides using a center point and first vertex.
        /// 
        /// </summary>
        /// <param name="center">Center point of the hexagon.</param>
        /// <param name="vertex">First vertex of the hexagon.</param>
        /// <param name="sides">Number of sides of the polygon.</param>
        public PolygonR(Point center, Point vertex, int sides)
        {
            // In a regular polygon, its centroid is the center of the
            // circle that circumscribes it.
            this.centroid = center;
            // Calculate the other vertex of the polygon
            double increment = 2 * Math.PI / sides;
            double radius = center.DistanceTo(vertex);
            double theta = Math.Atan2(vertex.Y - center.Y, vertex.X - center.X);
            for (int i = 0; i < sides; i++)
            {
                this.vertices.Add(new Point(
                    (int)(center.X + radius * Math.Cos(theta + i * increment)),
                    (int)(center.Y + radius * Math.Sin(theta + i * increment))));
            }
        }

        #endregion

        #region PUBLIC OVERRIDEN PROPERTIES

        /// <summary>
        /// 
        /// Returns the centroid of the polygon (READ-ONLY).
        /// 
        /// </summary>
        public override Point Centroid
        {
            get
            {
                return this.centroid;
            }
        }

        #endregion
    }
}
