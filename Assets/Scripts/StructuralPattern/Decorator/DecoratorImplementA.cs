using UnityEngine;
// 데코레이터 구현 : 추가적인 기능 구현
public class DecoratorImplementA : DecoratorBase
{
    public override void Op()
    {
        base.Op();
        Debug.Log("DecoratorImplementA.Op()");
    }
}
