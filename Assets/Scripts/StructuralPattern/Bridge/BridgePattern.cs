using UnityEngine;

// 브릿지 패턴

// 0. 정의
// => 기능 클래스와 구현 클래스를 분리
// => 새로운 기능을 추가하고 싶을 때 기능 클래스 확장
// => 각 기능에 대한 새로운 구현을 추가하고 싶을 때 구현 클래스 확장
// => 기능 클래스가 구현 클래스를 참조하여 기능과 구현을 잇는 다리 역할을 수행

// 1. 구성
// => 베이스 베이스 : 구현을 참조하여 기능과 구현을 잇고 연산 호출 기능 위임, 기능 정의
// => 베이스 구현 : 필요 시 기능 재정의
// => 구현 베이스 : 기능에 대한 구현 정의
// => 구현 구현 : 기능에 대한 구현 구현

// 2. 장점
// => 기능 클래스와 구현 클래스의 독립적인 확장이 가능함
// => 기능과 구현 간 종속성이 제거되어 결합도를 낮춤
// => 상속으로 확장 했을 때 보다 클래스의 급격한 증가를 방지함

// 3. 게임
// => 플레이어와 무기 관리 : 플레이어(기능)가 무기(구현)을 참조하여 플레이어가 특정 무기를 사용 할 수 있도록 이음
// => 몬스터와 AI 동작 관리 : 몬스터(기능)가 AI 동작(구현)을 참조하여 몬스터가 특정 상황에 특정 AI 동작을 할 수 있도록 이음
public class BridgePattern : MonoBehaviour
{
    private void Start()
    {
        // 각 연산의 호출을 위임하는 상위 인터페이스(다리 역할)
        BaseBase bs = new BaseImplement();

        // 구현 A의 연산 Set
        bs.Implement = new ImplementImplementA();
        bs.Op();
        bs.AdditionalOp();

        // 구현 B의 연산 Set
        bs.Implement = new ImplementImplementB();
        bs.Op();
        bs.AdditionalOp();
    }
}
