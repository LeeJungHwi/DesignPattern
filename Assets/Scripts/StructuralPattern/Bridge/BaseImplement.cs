using UnityEngine;
// 기능 구현 : 필요 시 기능 재정의
public class BaseImplement : BaseBase
{
    public override void Op()
    {
        Debug.Log("Op 호출 전");
        implement.Op();
        Debug.Log("Op 호출 후");
    }

    public override void AdditionalOp()
    {
        Debug.Log("AdditionalOp 호출 전");
        implement.AdditionalOp();
        Debug.Log("AdditionalOp 호출 후");
    }
}
