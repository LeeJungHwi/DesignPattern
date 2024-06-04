using UnityEngine;

// 전략 구현 : 전략 베이스를 상속받아 수행 할 알고리즘 구현
public class StrategyImplementA : StrategyBase
{
    public override void Mode(Transform transform)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 2);
        Debug.Log("걷기 모드");
    }
}
