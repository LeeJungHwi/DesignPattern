using UnityEngine;

// 추상 팩토리 패턴

// 0. 정의
// => 관련된 객체들을 추상팩토리에 몰아넣어 생성 할 수 있게함
// => 구현 클래스에 의존하지 않고 관련된 객체들을 생성 할 수 있게함

// 1. 구성
// => 추상팩토리 베이스 : 관련된 객체 생성 함수 정의
// => 추상팩토리 구현 : 추상팩토리 베이스를 상속받아 구현하여 관련된 다양한 객체 생성
// => 제품 베이스 : 생성 할 객체의 공통 멤버 정의
// => 제품 구현 : 제품 베이스를 상속받아 구체적인 객체 구현
// => 클라이언트 : 셋된 팩토리의 객체들을 생성하고 참조하여 사용

// 2. 장점
// => 관련된 객체들을 일관성 있게 생성 할 수 있음
// => 구현 클래스에 의존하지 않아 유연성 증가
// => 기존 코드 수정없이 새로운 객체를 추가 할 수 있음

// 3. 게임
// => 다양한 테마의 게임 오브젝트 생성 : 서로다른 레벨 또는 환경에서 다양한 적 캐릭터, 무기, 아이템 생성
// => 게임의 설정을 바꾸지 않고 쉽게 객체 모음을 교체 할 수 있어 유지보수 및 확장에 유리
public class AbstractFactoryPattern : MonoBehaviour
{
    // 클라에 추상팩토리 셋 후 사용
    private void Start()
    {
        AbstractFactoryBase f1 = new AbstractFactoryImplement1();
        Client c1 = new Client(f1);
        c1.Run();

        AbstractFactoryBase f2 = new AbstractFactoryImplement2();
        Client c2 = new Client(f2);
        c2.Run();
    }
}
