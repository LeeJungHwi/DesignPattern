using UnityEngine;

// 전략 베이스 : 이동 모드 추상 함수
public abstract class StrategyBase
{
    public abstract void Mode(Transform transform);
}
