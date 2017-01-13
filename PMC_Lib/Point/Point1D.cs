namespace PMC_Lib
{
    /// <summary>
    /// Describes point in 1D
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public class Point1D<T> : Point where T : struct
    {
        /// <summary>
        /// Returns X coordinate of point
        /// </summary>
        public T X { get; private set; }

        /// <summary>
        /// Creates new point with default value
        /// </summary>
        public Point1D() { }

        /// <summary>
        /// Creates new point with custom value
        /// </summary>
        /// <param name="x">X coordinate</param>
        public Point1D(T x)
        {
            X = x;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            return string.Format($"({X})");
        }
    }
}
