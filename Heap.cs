using System.Collections.Generic;

public abstract class Heap<T>
{
    List<T> heapList = new();
    public T Peek => heapList[0];
    public int Count => heapList.Count;
    int LastItemIndex => Count - 1;
    abstract protected bool ItemIsBetter(T item, T comparedItem);
    int ParentOf(int childIndex) => (childIndex - 1) / 2;
    int LeftChildOf(int parentIndex) => 2 * parentIndex + 1;
    int RightChildOf(int parentIndex) => 2 * parentIndex + 2;
    void Swap(int firstItemIndex, int secondItemIndex)
    {
        var temporaryItem = heapList[firstItemIndex];
        heapList[firstItemIndex] = heapList[secondItemIndex];
        heapList[secondItemIndex] = temporaryItem;
    }
    int BestItemAt(int parent)
    {
        if (LeftChildOf(parent) <= LastItemIndex)
        {
            int bestChild = LeftChildOf(parent);
            if(RightChildOf(parent) <= LastItemIndex &&
                ItemIsBetter(heapList[RightChildOf(parent)], heapList[bestChild]))
            {
                bestChild = RightChildOf(parent);
            }
            if (ItemIsBetter(heapList[bestChild], heapList[parent]))
            {
                return bestChild;
            }
        }
        return parent;
    }
    public T Extract()
    {
        var parent = heapList[0];
        Swap(0, LastItemIndex);
        heapList.RemoveAt(LastItemIndex);
        int testedItem = 0;
        int bestItem = BestItemAt(testedItem);
        while (testedItem != bestItem)
        {
            Swap(testedItem, bestItem);
            testedItem = bestItem;
            bestItem = BestItemAt(testedItem);
        }
        return parent;
    }
    public void Insert(T itemToInsert)
    {
        heapList.Add(itemToInsert);
        int testedItem = LastItemIndex;
        while (testedItem > 0 && ItemIsBetter(heapList[testedItem], heapList[ParentOf(testedItem)]))
        {
            Swap(testedItem, ParentOf(testedItem));
            testedItem = ParentOf(testedItem);
        }
    }
}