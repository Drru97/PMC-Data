namespace PMC_Lib
{
    /// <summary>
    /// Describes point in 2D
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public class Point2D<T> : Point where T : struct
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
        /// Creates new point with default value
        /// </summary>
        public Point2D() { }

        /// <summary>
        /// Creates new point with custom value
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            return string.Format($"({X}; {Y})");
        }
    }
}
