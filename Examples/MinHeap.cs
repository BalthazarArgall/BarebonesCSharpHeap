using System;

public class MinHeap<T> : HeapAbstract<T> where T : IComparable
{
    protected override bool ItemIsBetter(T item, T comparedItem) => item.CompareTo(comparedItem) < 0;
}