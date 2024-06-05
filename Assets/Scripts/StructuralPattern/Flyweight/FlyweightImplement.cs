using UnityEngine;
// 플라이웨이트 구현 : 공유되는 플라이웨이트 객체
public class FlyweightImplement : FlyweightBase
{
    public override void Op(int externalState) { Debug.Log("FlyweightImplement : " + externalState); }
}
