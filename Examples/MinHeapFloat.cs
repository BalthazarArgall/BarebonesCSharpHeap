public class MinHeapFloat : HeapAbstract<float>
{
    protected override bool ItemIsBetter(float item, float comparedItem) => item < comparedItem ? true : false;
}