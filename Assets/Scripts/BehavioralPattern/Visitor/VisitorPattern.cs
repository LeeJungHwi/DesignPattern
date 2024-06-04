using UnityEngine;

// 방문자 패턴

// 0. 정의
// => 객체 구조에 새로운 연산을 추가하고자 할 때 사용
// => 연산을 객체 외부에 정의하고 객체 구조를 순회하며 연산을 적용하는 방식

// 1. 구성
// => 방문자 베이스 : 객체 구조의 각 요소에 대해 연산을 수행하는 함수 정의
// => 방문자 구현 : 방문자 베이스를 상속받아 구현하며, 각 요소에 대한 구체적인 연산 정의
// => 요소 베이스 : 방문자를 받아들이는 함수 정의
// => 요소 구현 : 요소 베이스를 상속받아 구현하며, Accept 함수를 통해 방문자를 받아들여 방문자가 해당 요소에 대한 연산을 수행하도록 함
// => 요소 오브젝트 : 요소들을 관리하며, 각 요소에 방문자를 적용함

// 2. 장점
// => 유연성 : 기존 객체 구조를 변경하지 않고 새로운 기능을 추가 할 수 있음
// => 다형성 : 각 요소 타입에 대해 다른 연산을 적용 할 수 있음
// => 가독성 : 객체 구조와 연산을 분리하여 코드의 응집도와 가독성을 높임

// 3. 게임
// => 서로 다른 종류의 게임 오브젝트가 충돌 했을 때, 각 충돌 처리를 방문자 객체에서 정의 할 수 있음 : 플레이어가 아이템을 먹었을 때와 적과 충돌했을 때의 다른 처리 연산
// => 게임 오브젝트의 상태를 검사하고 업데이트하는 로직을 구현 할 수 있음 : 모든 게임 오브젝트에 대해 상태를 확인하고 필요에 따라 행동을 변경하거나 속성을 업데이트
// => 서로 다른 렌더링 로직을 각 요소에 대해 정의 할 수 있음 : 특정 오브젝트는 특정 쉐이더를 적용하는 로직을 방문자 객체에 구현 할 수 있음
public class VisitorPattern : MonoBehaviour
{
    private void Start()
    {
        // 요소
        ElementObject eo = new ElementObject();
        
        // 관리 할 요소 추가
        eo.Attach(new ElementImplementA());
        eo.Attach(new ElementImplementB());

        // 방문자
        VisitorImplementA va = new VisitorImplementA();
        VisitorImplementB vb = new VisitorImplementB();

        // 각 요소에 다른 연산 적용
        eo.Accept(va);
        eo.Accept(vb);
    }
}