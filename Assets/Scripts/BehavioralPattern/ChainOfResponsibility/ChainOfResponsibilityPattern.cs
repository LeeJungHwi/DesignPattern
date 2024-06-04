using System.Collections.Generic;
using UnityEngine;

// 책임 연쇄 패턴

// 0. 정의
// => 요청을 처리 할 수 있는 여러 객체가 연쇄적으로 연결 될 수 있는 구조를 제공
// => 한 객체가 처리하지 못하는 요청을 다음 객체로 넘겨서 처리

// 1. 구성
// => 핸들러 베이스 : 요청 처리 및 다음 핸들러로 요청을 넘김
// => 핸들러 구현 : 핸들러 베이스를 상속받아 실제 요청 처리

// 2. 장점
// => 클라이언트는 어떤 객체가 요청을 처리할지 알 필요가 없이 첫 번째 핸들러에 요청을 전달하면 되며 각 핸들러는 자신이 처리 할 수 있는 요청 범위 내에서 처리하거나 처리하지 못하면 다음 핸들러로 요청을 넘기는 방식으로 동작하여 결합도 낮춤
// => 새로운 핸들러를 추가해도 기존 코드에 영향을 주지않고 확장 할 수 있음
// => 각 핸들러 객체가 단일 책임 원칙을 지키면서 자신이 처리 할 수 있는 요청만 처리 할 수 있음

// 3. 게임
// => 이벤트 처리 시스템 : 충돌, 상호작용, 사용자 입력
// => AI 의사 결정 : 게임 캐릭터의 행동 결정
// => 로깅 및 디버깅 : 정보, 경고, 오류 로그 처리

public class ChainOfResponsibilityPattern : MonoBehaviour
{
    private void Start()
    {
        // 초기화
        HandlerBase h1 = new HandlerImplementA();
        HandlerBase h2 = new HandlerImplementB();
        HandlerBase h3 = new HandlerImplementC();
        h1.SetHandler(h2, 0, 10);
        h2.SetHandler(h3, 10, 20);
        h3.SetHandler(null, 20, 30);

        // 요청 전달
        List<int> requestList = new List<int> { 2, 5, 14, 22, 18, 3, 27, 20 };
        foreach(int request in requestList) h1.HandleRequest(request);
    }
}
