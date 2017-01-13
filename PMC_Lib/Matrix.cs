using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PMC_Lib
{
    /// <summary>
    /// Abstract class to describe matrix in general
    /// </summary>
    public abstract class Matrix { }

    /// <summary>
    /// Class that describes matrix
    /// </summary>
    /// <typeparam name="T">Type of matrix position</typeparam>
    public class Matrix<T> : Matrix, IEnumerable, IEnumerator where T : Position
    {
        /// <summary>
        /// List of the positions in the matrix
        /// </summary>
        public List<T> Positions { get; set; }
        /// <summary>
        /// Gets the current element in the collection
        /// </summary>
        public object Current => Positions[_index];

        private int _index = -1;

        /// <summary>
        /// Creates new empty matrix
        /// </summary>
        public Matrix()
        {
            Positions = new List<T>();
        }

        /// <summary>
        /// Adds new position to the matrix
        /// </summary>
        /// <param name="position">Position to add</param>
        public void AddPosition(params T[] position)
        {
            if (position.Any(t => Positions.Any(pos => pos.GetPointsCount() != t.GetPointsCount())))
                throw new ArgumentException();

            foreach (var pos in position)
                Positions.Add(pos);
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
            if (_index == Positions.Count - 1)
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
            string result = string.Empty;
            for (int i = 0; i < Positions.Count; i++)
                result += $"Position {i}:\n" + Positions[i] + "\n";
            return result;
        }
    }
}
