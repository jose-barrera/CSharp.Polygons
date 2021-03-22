using System;

namespace Polygons
{
    /// <summary>
    /// 
    /// Represents a cartesian point.
    /// 
    /// </summary>
    public class Point
    {
        #region INTERNAL FIELDS

        private float x;
        private float y;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// Builds the origin point (0,0).
        /// 
        /// </summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>
        /// 
        /// Bulds the point indicated by coordinates provided.
        /// 
        /// </summary>
        /// <param name="x">Coordinate along x axis.</param>
        /// <param name="y">Coordinate along y axis.</param>
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// 
        /// Returns the horizontal coordinate (READ-ONLY).
        /// 
        /// </summary>
        public float X
        {
            get
            {
                return this.x;
            }
        }

        /// <summary>
        /// 
        /// Returns the vertical coordinate (READ-ONLY).
        /// 
        /// </summary>
        public float Y
        {
            get
            {
                return this.y;
            }
        }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// 
        /// Calculates the euclidian distance between this point
        /// and another point.
        /// 
        /// </summary>
        /// <param name="other">The point to calcute distance from.</param>
        /// <returns>The distance between points.</returns>
        public float DistanceTo(Point other)
        {
            return (float)Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
        }

        /// <summary>
        /// 
        /// Moves the point to another position.
        /// 
        /// </summary>
        /// <param name="dx">Horizontal displacement.</param>
        /// <param name="dy">Vertical displacement.</param>
        public void Translate(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }

        /// <summary>
        /// 
        /// Rotates the point around a center on theta angle.
        /// 
        /// </summary>
        /// <param name="center">Center of rotation.</param>
        /// <param name="theta">Rotation angle.</param>
        public void Rotate(Point center, float theta)
        {
            double radians = theta * Math.PI / 180;
            float newX = (float)(Math.Cos(radians) * (this.x - center.X) + Math.Sin(radians) * (this.y - center.Y) + center.X);
            float newY = (float)(-Math.Sin(radians) * (this.x - center.X) + Math.Cos(radians) * (this.y - center.Y) + center.Y);
            this.x = newX;
            this.y = newY;
        }

        /// <summary>
        /// 
        /// Generates a copy ot the point object.
        /// 
        /// </summary>
        /// <returns>A shallow copy.</returns>
        public Point Clone()
        {
            return (Point)this.MemberwiseClone();
        }

        #endregion

        #region PUBLIC OVERRIDEN METHODS

        /// <summary>
        /// 
        /// Redefines the comparison of Point objects.
        /// Two points are equal if both coordinates are equal.
        /// 
        /// </summary>
        /// <param name="obj">Object to compare to.</param>
        /// <returns>A logical value based on comparison.</returns>
        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj != null && obj is Point)
            {
                Point other = (Point)obj;
                result = this.x == other.x && this.y == other.y;
            }

            return result;
        }

        /// <summary>
        /// 
        /// Redefines the hashcode calculation according to C# recomendation.
        /// 
        /// </summary>
        /// <returns>An Int32 value that represents the object's hashcode.</returns>
        public override int GetHashCode()
        {
            return ShiftAndWrap(this.x.GetHashCode(), 2) ^ this.y.GetHashCode();
        }

        /// <summary>
        /// 
        /// Redefines the string representation of this
        /// object.
        /// 
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return "(" + this.x + " , " + this.y + ")";
        }

        #endregion

        #region STATIC PUBLIC METHODS

        /// <summary>
        /// 
        /// Redefines the + operator (addition of two points).
        /// 
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Sum of two points.</returns>
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        /// <summary>
        /// 
        /// Redefines the - operator (subtraction of two points).
        /// 
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Difference between two points.</returns>
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        /// <summary>
        /// 
        /// Redefines the equality operator.
        /// 
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <returns>True if points are equal.</returns>
        public static bool operator ==(Point a, Point b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 
        /// Redefines the inequality operator.
        /// 
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <returns>True if points are not equal.</returns>
        public static bool operator !=(Point a, Point b)
        {
            return !a.Equals(b);
        }

        #endregion

        #region PRIVATE METHDOS

        /// <summary>
        /// 
        /// Auxiliar method as is from C# documentation for Object.GetHashCode method.
        /// 
        /// </summary>
        /// <param name="value">Value to shift.</param>
        /// <param name="positions">Number of bits to left-shift.</param>
        /// <returns></returns>
        private int ShiftAndWrap(int value, int positions)
        {
            positions = positions & 0x1F;

            // Save the existing bit pattern, but interpret it as an unsigned integer.
            uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
            // Preserve the bits to be discarded.
            uint wrapped = number >> (32 - positions);
            // Shift and wrap the discarded bits.
            return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
        }

        #endregion
    }
}
