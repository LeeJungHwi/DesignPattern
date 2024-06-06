using UnityEngine;
// 서브 클래스 : 하위클래스로 각각의 독립적인 동작 구현
public class SubClassC : BaseClass
{
    public override void Activate()
    {
        Debug.Log("SkyLaunch Activate");
        Move(10f);
        PlaySFX("SkyLaunch");
        PlayFX("SkyLaunch");
    }
}
