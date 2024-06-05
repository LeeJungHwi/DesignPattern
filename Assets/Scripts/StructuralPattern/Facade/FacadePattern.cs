using UnityEngine;

// 퍼사드 패턴

// 0. 정의
// => 복잡한 서브 시스템의 함수를 하나의 통합된 함수로 제공함
// => 서브 시스템의 복잡성을 숨기고 클라이언트가 더 간단한 인터페이스로 통합된 함수를 호출 할 수 있게함

// 1. 구성
// => 퍼사드 : 클라이언트가 사용하게 되는 각 시스템들의 함수를 통합한 함수를 제공하며 각 시스템을 캡슐화함
// => 시스템 : 퍼사드 객체가 감싸고 있는 복잡한 서브 시스템들로 각 기능이 정의 되어있으며, 클라이언트가 퍼사드의 통합된 함수로 사용

// 2. 장점
// => 단순화된 인터페이스 : 클라이언트는 복잡한 서브 시스템 내부 구현을 알 필요 없이 통합된 함수로 각 시스템을 사용 할 수 있음
// => 유연성 : 클라이언트와 서브 시스템 간 결합도를 낮춤
// => 가독성 : 복잡한 시스템을 단순화된 통합 인터페이스를 통해 처리 할 수 있음

// 3. 게임
// => 게임 엔진 통합 : 그래픽, 사운드, 물리 엔진 등 여러 서브 시스템의 복잡한 인터페이스를 단순화하여 개발자가 쉽게 사용할 수 있도록 함
// => UI 관리 : 여러 UI 요소의 복잡한 조작을 퍼사드 인터페이스를 통해 관리
// => 게임 로직 제어 : 게임 상태 관리, 레벨 로딩, 세이브 및 로드 등을 퍼사드 인터페이스를 통해 단순화
public class FacadePattern : MonoBehaviour
{
    private void Start()
    {
        Facade f = new Facade();

        // 각 시스템들의 특정 함수를 조합한 함수
        f.FuncCollectionA();
        f.FuncCollectionB();
    }
}
