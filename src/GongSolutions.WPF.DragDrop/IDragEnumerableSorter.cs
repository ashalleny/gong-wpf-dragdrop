﻿using System.Collections;

namespace GongSolutions.Wpf.DragDrop
{
    /// <summary>
    /// Interface for objects that sort an IEnumerable of drag drop items
    /// </summary>
    public interface IDragEnumerableSorter
    {
        /// <summary>
        /// Sort the IEnumerable of items
        /// </summary>
        /// <param name="items">Enumerable of dragged items to sort</param>
        /// <returns>The sorted list of dragged items</returns>
        IEnumerable SortDragDropItems(IEnumerable items);
    }
}
