using System.Collections.Generic;

// 관찰 대상자 베이스 : 옵저버 리스트를 관리하여 옵저버 추가 제거 알림
public class SubjectBase
{
    // 옵저버 리스트
    private List<ObserverBase> observerList = new List<ObserverBase>();

    // 옵저버 추가 제거 알림
    public void Attach(ObserverBase observer) { observerList.Add(observer); }
    public void Detach(ObserverBase observer) { observerList.Remove(observer); }
    public void Notify() { foreach(ObserverBase o in observerList) o.Update(); }
}
