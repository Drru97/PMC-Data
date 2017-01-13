namespace PMC_Lib
{
    /// <summary>
    /// Describes point in 3D
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public class Point3D<T> : Point where T : struct
    {
        /// <summary>
        /// Returns X coordinate of point
        /// </summary>
        public T X { get; private set; }
        /// <summary>
        /// Returns Y coordinate of point
        /// </summary>
        public T Y { get; private set; }
        /// <summary>
        /// Returns Z coordinate of point
        /// </summary>
        public T Z { get; private set; }

        /// <summary>
        /// Creates new point with default value
        /// </summary>
        public Point3D() { }

        /// <summary>
        /// Creates new point with custom value
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        public Point3D(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            return string.Format($"({X}; {Y}; {Z})");
        }
    }
}
