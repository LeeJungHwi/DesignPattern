using UnityEngine;

// 현재 상태를 참조하고 상태 변경 시 알림
public class StateContext
{
    // 상태 프로퍼티 => 상태 변경 시 추가 작업
    private StateBase state;
    public StateBase State
    {
        get { return state; }
        set
        {
            Debug.Log(state.GetType().Name + " => " + value.GetType().Name + " 타입으로 상태가 변경 되었습니다.");
            state = value;
        }
    }

    public StateContext(StateBase state) { this.state = state; }
    public void TransitionRequest() { state.Transition(this); } // 상태 전이 요청
}
