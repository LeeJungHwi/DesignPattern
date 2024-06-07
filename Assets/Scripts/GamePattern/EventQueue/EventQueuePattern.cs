using System.Collections.Generic;
using UnityEngine;

// 이벤트 큐 패턴

// 0. 정의
// => 송신자와 수신자를 시간적으로 분리하여 메시지 또는 이벤트를 송수신 처리를 분리

// 1. 구성
// => 이벤트 큐 매니저 : 이벤트를 관리하며, 이벤트 타입과 해당 이벤트 타입을 처리할 델리게이트를 맵핑하고, 외부 이벤트를 내부 이벤트로 추가하거나 삭제하는 기능 제공
// => 이벤트 큐 : 이벤트 메시지를 시작적으로 출력 하는 역할이며, 메시지의 색상 폰트 위치 설정
// => 이벤트 큐 패턴 : 마우스 클릭 이벤트 발생 시 무작위 메시지를 생성 후 이벤트 큐 매니저가 관리하도록 추가

// 2. 장점
// => 모듈화 : 시간적으로 송수신자를 분리
// => 복잡한 로직 처리 : 이벤트 큐를 통해 이벤트를 관리하고 처리

// 3. 게임
// => 마우스 클릭 시 무작위 메시지를 생성 후 이벤트 큐 매니저에 추가하고 메시지의 중요도와 지속 시간을 설정하여 메시지 이벤트 실행
public class EventQueuePattern : MonoBehaviour
{
    // 메시지 중요도 맵핑
    private Dictionary<MessagePriority, string> priorityMap = new Dictionary<MessagePriority, string>();

    private void Start()
    {
        priorityMap.Add(MessagePriority.Low, "Low");
        priorityMap.Add(MessagePriority.Normal, "Normal");
        priorityMap.Add(MessagePriority.High, "High");
    }

    // 마우스 클릭 시 메시지 이벤트 실행
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MessagePriority priority = MessagePriority.High;
            float random = Random.value;
            if(random < 0.333f) priority = MessagePriority.Low;
            else if(random < 0.666f) priority = MessagePriority.Normal;

            float showTime = Random.Range(1f, 5f);

            EventQueueManager.Instance.AddEvent(
                new MessageEvent("중요도 : " + priorityMap[priority] + " 현재 시간 : " + System.DateTime.Now + " 지속 시간 : " + showTime
                , Time.time + showTime, priority));
        }
    }
}
