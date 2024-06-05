using UnityEngine;

// 프로토타입 패턴

// 0. 정의
// => 객체를 복사하여 새로운 객체를 생성
// => 객체 생성 비용이 클 때 유용

// 1. 구성
// => 프로토타입 베이스 : 복제할 객체의 공통 멤버 정의
// => 프로토타입 구현 : 프로토타입 베이스를 상속받아 구현

// 2. 장점
// => 객체 생성 비용 절감 : 복잡한 객체를 새로 생성하는 대신 복제하여 사용 할 수 있음
// => 기존 객체를 기반으로 한 새로운 객체 생성 : 현재 상태를 유지한 채 새로운 객체를 만들기 쉬움
// => 런타임에 객체의 타입을 결정할 수 있음

// 3. 게임
// => 다양한 적 캐릭터, 아이템 등을 복제하여 생성
public class PrototypePattern : MonoBehaviour
{
    private void Start()
    {
        // 프로토타입 A 클론
        PrototypeImplementA pA = new PrototypeImplementA("A");
        PrototypeImplementA cA = (PrototypeImplementA)pA.Clone();
        Debug.Log(cA.Id + "클론");

        // 프로토타입 B 클론
        PrototypeImplementB pB = new PrototypeImplementB("B");
        PrototypeImplementB cB = (PrototypeImplementB)pB.Clone();
        Debug.Log(cB.Id + "클론");
    }
}
