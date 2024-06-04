using System.Collections.Generic;
// 요소 오브젝트 : 요소들을 관리하며, 요소 추가 요소 제거 요소에 방문자 패턴 적용
public class ElementObject
{
    private List<ElementBase> elementList = new List<ElementBase>();

    public void Attach(ElementBase element) { elementList.Add(element); } // 요소 추가
    public void Detach(ElementBase element) { elementList.Remove(element); } // 요소 삭제
    public void Accept(VisitorBase visitor) { foreach (ElementBase ele in elementList) ele.Accept(visitor); } // 연산 적용
}
