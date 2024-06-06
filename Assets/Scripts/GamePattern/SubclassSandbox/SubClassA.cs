using UnityEngine;
// 서브 클래스 : 하위클래스로 각각의 독립적인 동작 구현
public class SubClassA : BaseClass
{
    public override void Activate()
    {
        Debug.Log("FlashSpeed Activate");
        Move(100f);
        PlaySFX("FlasySpeed");
        PlayFX("FlashSpeed");
    }
}
