// 상태 복원 : 메멘토 상태 참조, 오브젝트의 특정 시점 상태가 저장되어있는 메멘토 상태로 오브젝트의 상태를 복원
public class RestoreState
{
    private MementoState memento;

    public MementoState Memento
    {
        get { return memento; }
        set { memento = value; }
    }
}
