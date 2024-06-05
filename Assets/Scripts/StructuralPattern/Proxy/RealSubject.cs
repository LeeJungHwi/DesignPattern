using UnityEngine;
// 실제 주체 : 실제 작업을 수행하는 주체
public class RealSubject : Subject
{
    public override void Request() { Debug.Log("RealSubject.Request()"); }
}
