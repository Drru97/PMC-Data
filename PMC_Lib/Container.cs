using System.Collections;
using System.Collections.Generic;

namespace PMC_Lib
{
    /// <summary>
    /// Class describes a container that contains matrices of PMC Data Specification
    /// </summary>
    public class Container : IEnumerable, IEnumerator
    {
        /// <summary>
        /// List of matrices
        /// </summary>
        public List<Matrix> Matrices { get; set; }
        /// <summary>
        /// Gets the current element in the collection
        /// </summary>
        public object Current => Matrices[_index];

        private int _index = -1;

        /// <summary>
        /// Creates new empty container
        /// </summary>
        public Container()
        {
            Matrices = new List<Matrix>();
        }

        /// <summary>
        /// Creates new non-empty container
        /// </summary>
        /// <param name="matrix">Container to add</param>
        public Container(params Matrix[] matrix) : this()
        {
            AddMatrix(matrix);
        }

        /// <summary>
        /// Adds new matrix to the container
        /// </summary>
        /// <param name="matrix"></param>
        public void AddMatrix(params Matrix[] matrix)
        {
            foreach (var matr in matrix)
                Matrices.Add(matr);
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
            if (_index == Matrices.Count - 1)
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
            for (int i = 0; i < Matrices.Count; i++)
                result += $"Matrix {i}:\n" + Matrices[i] + "\n";
            return result;
        }
    }
}
