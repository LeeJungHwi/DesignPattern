using UnityEngine;
// 서브 클래스 : 하위클래스로 각각의 독립적인 동작 구현
public class SubClassB : BaseClass
{
    public override void Activate()
    {
        Debug.Log("GroundDive Activate");
        Move(15f);
        PlaySFX("GroundDive");
        PlayFX("GroundDive");
    }
}
