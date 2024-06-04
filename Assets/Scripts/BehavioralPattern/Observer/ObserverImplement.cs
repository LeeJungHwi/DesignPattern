using UnityEngine;

// 옵저버 구현 : 관찰 대상자의 상태를 실제 업데이트
public class ObserverImplement : ObserverBase
{
    private string name; // 옵저버 이름
    private string observerState; // 옵저버 상태
    private SubjectImplement subject; // 관찰 대상자 프로퍼티
    public SubjectImplement Subject
    {
        get { return subject; }
        set { subject = value; }
    }
    public ObserverImplement(SubjectImplement subject, string name)
    {
        this.subject = subject;
        this.name = name;
    }
    public override void Update()
    {
        observerState = subject.SubjectState;
        Debug.Log("옵저버 " + name + "가 관리하는 " + subject + " 의 상태가 " + observerState + " 으로 변경되었습니다.");
    }
}
