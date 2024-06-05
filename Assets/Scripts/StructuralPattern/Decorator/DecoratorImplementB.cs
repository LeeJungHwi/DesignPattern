using UnityEngine;
// 데코레이터 구현 : 추가적인 기능 구현
public class DecoratorImplementB : DecoratorBase
{
    public override void Op()
    {
        base.Op();
        AdditionalOp();
        Debug.Log("DecoratorImplementB.Op()");
    }

    private void AdditionalOp() { Debug.Log("DecoratorImplementB.AdditionalOp()"); }
}
