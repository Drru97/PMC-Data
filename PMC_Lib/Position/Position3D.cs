using System.Collections;
using System.Collections.Generic;

namespace PMC_Lib
{
    /// <summary>
    /// Describes 3D position
    /// </summary>
    /// <typeparam name="T">Data type of point</typeparam>
    public class Position3D<T> : Position, IEnumerable, IEnumerator where T : struct
    {
        /// <summary>
        /// List of points in the position
        /// </summary>
        public List<Point3D<T>> Points { get; set; }
        /// <summary>
        /// Gets the current element in the collection
        /// </summary>
        public object Current => Points[_index];

        private int _index = -1;

        /// <summary>
        /// Creates new empty position
        /// </summary>
        public Position3D()
        {
            Points = new List<Point3D<T>>();
        }

        /// <summary>
        /// Adds new point to the position
        /// </summary>
        /// <param name="point">Point to add</param>
        public void AddPoint(params Point3D<T>[] point)
        {
            foreach (var p in point)
                if (p != null)
                    Points.Add(p);
        }

        /// <summary>
        /// Returns count of points in the position
        /// </summary>
        /// <returns>Count of points in the position</returns>
        public override int GetPointsCount()
        {
            return Points.Count;
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection
        /// </summary>
        /// <returns>An System.Collections.IEnumerator object that can be used to iterate through the collection</returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection
        /// </summary>
        /// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection</returns>
        public bool MoveNext()
        {
            if (_index == Points.Count - 1)
            {
                Reset();
                return false;
            }
            _index++;
            return true;
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection
        /// </summary>
        public void Reset()
        {
            _index = -1;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            foreach (var p in Points)
                return p.ToString();
            return "No points in this position";
        }
    }
}
