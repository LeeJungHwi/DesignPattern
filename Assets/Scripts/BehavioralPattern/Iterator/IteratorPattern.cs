using UnityEngine;

// 반복자 패턴

// 0. 정의
// => 컬렉션의 요소들에 순차적으로 접근 할 수 있는 반복자 제공
// => 컬렉션의 내부 표현을 노출하지 않고 컬렉션의 모든 요소를 순회 할 수 있음

// 1. 구성
// => 반복자 베이스 : 첫 아이템, 다음 아이템, 순회 끝났는지 체크, 현재 아이템 추상 함수
// => 반복자 구현 : 반복자 베이스를 상속받아 실제 연산을 구현
// => 연산자 베이스 : 반복자를 생성하는 추상 함수
// => 연산자 구현 : 연산자 베이스를 상속받아 아이템 리스트 관리 및 아이템 리스트를 순회 할 반복자 생성하고 바인딩

// 2. 장점
// => 일관된 인터페이스 : 다양한 컬렉션 구조에 대해 동일한 방식으로 요소를 순회 할 수 있음
// => 컬렉션 내부구조 은닉 : 컬렉션의 내부구조를 노출하지 않고 요소에 접근 할 수 있음 
// => 단일 책임 원칙 준수 : 컬렉션을 관리하는 클래스와 컬렉션을 순회하는 클래스를 분리하여 각 클래스가 단일 책임을 가짐

// 3. 게임
// => 게임 오브젝트 컬렉션을 순회하여 각 오브젝트에 특정 행동을 수행 할 수 있음
// => 인벤토리 시스템에서 아이템 리스트를 순회하여 아이템을 출력하는 작업을 할 수 있음

public class IteratorPattern : MonoBehaviour
{
    private void Start()
    {
        // 아이템 초기화
        CalcImplement calc = new CalcImplement();
        calc[0] = "Item A";
        calc[1] = "Item B";
        calc[2] = "Item C";
        calc[3] = "Item D";

        // 반복자 초기화
        IteratorBase it = calc.CreateIterator();

        // 아이템 순회
        object item = it.FirstItem();
        while(item != null)
        {
            Debug.Log(it.CurItem());
            item = it.NextItem();
            if(it.IsCircuit()) Debug.Log("Done Calc"); 
        }
    }
}
