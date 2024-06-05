using UnityEngine;

// 데코레이터 패턴

// 0. 정의
// => 객체들을 래핑하여 새로운 기능을 추가함
// => 서브클래스의 생성없이 기능을 유연하게 추가 할 수 있음

// 1. 구성
// => 컴포넌트 베이스 : 기본 객체에 대한 멤버 정의
// => 컴포넌트 구현 : 컴포넌트 베이스를 상속받아 구현
// => 데코레이터 베이스 : 컴포넌트 베이스의 기능을 유지하면서 새로운 기능을 정의
// => 데코레이터 구현 : 데코레이터 베이스를 상속받아 새로운 기능 구현

// 2. 장점
// => 확장성 : 객체의 기능을 동적으로 확장 할 수 있음
// => 유연성 : 서브클래스를 만들지 않고 다양한 기능을 조합 할 수 있음
// => 단일 책임 원칙 : 각 데코레이터에 고유기능을 유지 할 수 있음

// 3. 게임
// => 아이템 속성 부여 : 게임 아이템에 다양한 속성을 동적으로 추가하여 다양한 조합을 만들 수 있음
// => 캐릭터 능력 추가 : 게임 캐릭터에 새로운 능력을 동적으로 추가하여 유연하게 캐릭터를 강화함
// => UI 요소 데코 : UI 요소에 동적으로 다양한 데코를 추가하여 인터페이스를 유연하게 구성 할 수 있음
public class DecoratorPattern : MonoBehaviour
{
    private void Start()
    {
        // 초기화
        ComponentImplement c = new ComponentImplement();
        DecoratorImplementA da = new DecoratorImplementA();
        DecoratorImplementB db = new DecoratorImplementB();

        // 연결 => 기능확장
        da.SetComponent(c);
        db.SetComponent(da);

        // 마지막 데코의 연산 호출 => 모든 연산 호출
        // 새로운 기능을 확장하고 싶다면 새로운 데코 dc를 생성하여 구현하고 링킹 후 dc.Op() 호출
        // 각 데코에서 base 연산을 첫 줄에 호출하여 호출 순서는 아래와 같음
        // 1. c.Op()
        // 2. da.Op()
        // 3. db.Op()
        // 4. dc.Op()
        db.Op();
    }
}
