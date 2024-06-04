using UnityEngine;
// 방문자 구현 : 각 요소를 방문 했을 때 특정 동작 구현
public class VisitorImplementA : VisitorBase
{
    public override void VisitElementImplementA(ElementImplementA a) { Debug.Log(a.GetType().Name + " 가 " + this.GetType().Name + " 에 의해 방문되었다"); }
    public override void VisitElementImplementB(ElementImplementB b) { Debug.Log(b.GetType().Name + " 가 " + this.GetType().Name + " 에 의해 방문되었다"); }
}
