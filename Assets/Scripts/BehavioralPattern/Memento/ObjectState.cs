using UnityEngine;

// 오브젝트 상태 : 오브젝트 상태 관리, 오브젝트의 현재 상태를 저장하고 나중에 복원 할 수 있음
public class ObjectState
{
    // 오브젝트 상태
    private string state;
    public string State
    {
        get { return state; }
        set
        {
            Debug.Log(state + " 상태에서 " + value + " 상태로 변경");
            state = value;
        }
    }

    // 오브젝트의 특정 시점을 저장하는 메멘토 생성
    public MementoState CreateMemento() { return new MementoState(state); }

    // 특정 메멘토로 오브젝트의 상태를 복원
    public void RestoreMement(MementoState memento) { State = memento.State; }
}
