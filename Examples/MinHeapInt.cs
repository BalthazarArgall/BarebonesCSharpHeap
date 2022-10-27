public class MinHeapInt : HeapAbstract<int>
{
    protected override bool ItemIsBetter(int item, int comparedItem) => item < comparedItem ? true : false;
}