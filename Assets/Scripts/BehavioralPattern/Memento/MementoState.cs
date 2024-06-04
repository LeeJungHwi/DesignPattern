// 메멘토 상태 : 오브젝트의 특정 시점 상태를 저장
public class MementoState
{
    private string state;
    public string State { get{ return state; }} 
    
    public MementoState(string state) { this.state = state; }
}
