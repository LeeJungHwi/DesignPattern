// 요소 구현 : 방문자를 받아들이는 함수 구현
public class ElementImplementB : ElementBase
{
    public override void Accept(VisitorBase visitor) { visitor.VisitElementImplementB(this); }
}
