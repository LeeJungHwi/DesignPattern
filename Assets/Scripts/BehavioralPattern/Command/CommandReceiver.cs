using UnityEngine;

// 수신자 => 실제 작업을 수행
public class CommandReceiver
{
    public void Do() { Debug.Log("Do Attack"); }
    public void Undo() { Debug.Log("Cancel Attack"); }
}
