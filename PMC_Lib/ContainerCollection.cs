using System.Collections;
using System.Collections.Generic;

namespace PMC_Lib
{
    /// <summary>
    /// Class describes a collection of containers of PMC Data Specification
    /// </summary>
    public class ContainerCollection : IEnumerable, IEnumerator
    {
        /// <summary>
        /// List of containers
        /// </summary>
        public List<Container> Containers { get; set; }
        /// <summary>
        /// Gets the current element in the collection
        /// </summary>
        public object Current => Containers[_index];

        private int _index = -1;

        /// <summary>
        /// Creates new emply collection of containers
        /// </summary>
        public ContainerCollection()
        {
            Containers = new List<Container>();
        }

        /// <summary>
        /// Creates new non-empty collection of containers
        /// </summary>
        /// <param name="container">Container to add</param>
        public ContainerCollection(params Container[] container) : this()
        {
            AddContainer(container);
        }

        /// <summary>
        /// Adds new container to the collection
        /// </summary>
        /// <param name="container">Container to add</param>
        public void AddContainer(params Container[] container)
        {
            //foreach (Container t in Containers)
            //    for (int m = 0; m < t.Matrices.Count; m++)
            //        if (t.Matrices[m].Positions.Count != container.Matrices[m].Positions.Count)
            //            throw new ArgumentException();
            foreach (var cont in container)
                Containers.Add(cont);
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
            if (_index == Containers.Count - 1)
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
            for (int i = 0; i < Containers.Count; i++)
                result += $"Container{i}" + Containers[i] + "\n";
            return result;
        }
    }
}
