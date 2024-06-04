// 관찰 대상자 구현 : 관찰 대상자 상태 유지
public class SubjectImplement : SubjectBase
{
    // 관찰 대상자 상태 프로퍼티
    private string subjectState;
    public string SubjectState
    {
        get { return subjectState; }
        set { subjectState = value; }
    }
}
