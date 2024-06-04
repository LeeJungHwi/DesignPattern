// 상태 전환 : 상태 전이 함수 구현 A => B
public class StateImplementA : StateBase
{
    public override void Transition(StateContext context) { context.State = new StateImplementB(); }
}
