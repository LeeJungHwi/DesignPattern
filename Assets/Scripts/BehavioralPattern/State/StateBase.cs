// 상태 베이스 : 상태 전이 추상 함수
public abstract class StateBase
{
    public abstract void Transition(StateContext context);
}
