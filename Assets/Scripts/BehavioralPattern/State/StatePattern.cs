using UnityEngine;

// 상태 패턴

// 0. 정의
// => 객체의 상태가 변경될 때 해당 객체의 행동도 변경
// => 상태를 캡슐화하고 상태 전이를 통해 객체의 행동을 동적으로 변경

// 1. 구성
// => 상태 베이스 : 상태 전이 추상 함수
// => 상태 구현 : 상태 베이스를 상속 받아 상태 전이 함수 오버라이드 구현
// => 상태 컨텍스트 : 현재 상태를 관리하고 실제 상태 전이 수행

// 2. 장점
// => 상태에 따른 행동을 캡슐화하여 코드 가독성 및 유지보수 향상
// => 상태 전이 로직을 각 상태 클래스에서 구현하여 복잡성 낮춤
// => 새로운 상태를 추가하거나 기존 상태를 변경할 때 다른 상태나 컨텍스트를 수정하지 않아도 됨

// 3. 게임
// => 플레이어의 행동, 게임 객체의 상태 관리 : 걷기, 뛰기, 점프 상태에 따른 행동 관리

public class StatePattern : MonoBehaviour
{
    private void Start()
    {
        // 초기화
        StateContext c = new StateContext(new StateImplementA());

        // 상태 전이
        c.TransitionRequest();
        c.TransitionRequest();
        c.TransitionRequest();
        c.TransitionRequest();
    }
}
