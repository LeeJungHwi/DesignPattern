// 반복자 구현 : 연산자 참조, 반복자 베이스를 상속받아 실제 연산 구현
public class IteratorImplement : IteratorBase
{
    private CalcImplement calc;
    private int curCalcIdx = 0;

    public IteratorImplement(CalcImplement calc) { this.calc = calc; }

    public override object FirstItem() { return calc[0]; }

    public override object NextItem()
    {
        object nextItem = null;
        if(curCalcIdx < calc.Count - 1) nextItem = calc[++curCalcIdx];
        else ++curCalcIdx;
        return nextItem;
    }

    public override object CurItem() { return calc[curCalcIdx]; }

    public override bool IsCircuit() { return curCalcIdx >= calc.Count; }
}
