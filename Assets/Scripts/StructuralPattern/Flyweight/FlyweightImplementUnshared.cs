using UnityEngine;
// 플라이웨이트 비공유 : 공유되지 않는 플라이웨이트 객체, 해쉬맵에 저장되지않고 필요시 독립적으로 생성
public class FlyweightImplementUnshared : FlyweightBase
{
    public override void Op(int externalState) { Debug.Log("FlyweightImplementUnshared : " + externalState); }
}
