using System.Collections.Generic;
// 연산자 구현 : 연산에 사용 할 아이템 리스트 관리, 아이템 리스트 순회 할 반복자 생성 후 바인딩
public class CalcImplement : CalcBase
{
    private List<object> itemList = new List<object>();

    public override IteratorBase CreateIterator() { return new IteratorImplement(this); }

    // 아이템 수
    public int Count { get { return itemList.Count; } }

    // 인덱스 접근
    public object this[int idx]
    {
        get { return itemList[idx]; }
        set { itemList.Insert(idx, value); }
    }
}
