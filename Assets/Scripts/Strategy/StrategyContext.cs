using UnityEngine;

// 전략 컨텍스트 : 전략 참조, 수행 할 전략 알고리즘을 설정하고 실행
public class StrategyContext
{
    private StrategyBase strategy;

    public StrategyContext(StrategyBase strategy) { this.strategy = strategy; }

    public void SetMode(StrategyBase strategy) { this.strategy = strategy; }

    public void ExcuteMode(Transform transform) { strategy.Mode(transform); }
}
