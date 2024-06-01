// 상태 전환 : 상태 전이 함수 구현 B => A
public class StateImplementB : StateBase
{
    public override void Transition(StateContext context) { context.State = new StateImplementA(); }
}
