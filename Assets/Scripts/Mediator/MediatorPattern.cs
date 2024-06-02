using UnityEngine;

// 중재자 패턴

// 0. 정의
// => 객체 간 상호작용을 중재
// => 객체들이 서로 직접적으로 통신하지 않고 중재자를 통해 통신

// 1. 구성
// => 중재자 : 당사자들 간 상호작용을 중재하는 객체로 당사자들 간 직접적인 통신을 제어하고 객체 간 관계 관리
// => 당사자 : 중재자에 의해 중재되는 객체로 중재자를 통해 다른 당사자와 통신

// 2. 장점
// => 각 객체는 중재자와만 통신하므로 의존성 및 결합도 낮춤
// => 새로운 객체를 추가하거나 기존 객체 변경 시 중재자만 수정하면 되므로 유지보수 쉬움
// => 객체 간 통신 로직이 중재자에 몰아넣어 간결하고 명확하게 구조화된 코드

// 3. 게임
// => 게임 이벤트 처리 : 중재자는 게임 객체 간 이벤트를 조정하고 관리
// => 플레이어 간 통신 : 멀티 게임에서 중재자를 통한 채팅 시스템
// => AI 상호작용 : 각 AI 요소는 중재자를 통해 다른 AI 요소와 통신하여 협력하거나 경쟁

public class MediatorPattern : MonoBehaviour
{
    private void Start()
    {
        // 중재자 및 당사자 초기화
        MediatorImplement m = new MediatorImplement();

        PartyImplementA a = new PartyImplementA(m);
        PartyImplementB b = new PartyImplementB(m);

        m.PartyA = a;
        m.PartyB = b;

        // 중재자를 통한 당사자 간 메시지 전달
        a.Send("어떻게 지내?");
        b.Send("잘 지내, 고마워");
    }
}
