// 반복자 베이스 : 첫 아이템, 다음 아이템, 순회 끝났는지, 현재 아이템
public abstract class IteratorBase
{
    public abstract object FirstItem();
    public abstract object NextItem();
    public abstract bool IsCircuit();
    public abstract object CurItem();
}
