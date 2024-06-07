using System.Collections.Generic;
using UnityEngine;

// 이벤트 큐 : 이벤트 메시지를 시작적으로 출력 하는 역할이며, 메시지의 색상 폰트 위치 설정
public class EventQueue : MonoBehaviour
{
    // 메시지 로그 출력 체크
    public bool log = true;

    // 메시지 시간 포함 체크
    public bool preMessageTime = false;

    // 메시지 색상
    public Color highPriorityColor = Color.red;
    public Color normalPriorityColor = Color.black;
    public Color lowPriorityColor = Color.white;

    // 메시지 폰트
    public FontStyle highPriorityFont = FontStyle.Bold;
    public FontStyle normalPriorityFont = FontStyle.Normal;
    public FontStyle lowPriorityFont = FontStyle.Normal;

    // 메시지 위치
    public Vector2 messagePos = new Vector2(25, 25);
    public Vector2 messageSize = new Vector2(200, 15);
    private static readonly GUIStyle LOW_PRIORITY = new GUIStyle(), NORMAL_PRIORITY = new GUIStyle(), HIGH_PRIORITY = new GUIStyle();
    
    // 메시지 관리
    private List<IMessageEvent> eventQueueList = new List<IMessageEvent>();

    // 메시지가 관리되도록 추가
    private void AddEvent(IMessageEvent e)
    {
        eventQueueList.Add(e);
        if(log) Debug.Log(System.DateTime.Now + " : " + e.message.ToString());
    }

    // 메시지 이벤트 큐 초기화
    private void Start()
    {
        if(eventQueueList.Count > 0) eventQueueList.Clear();
        EventQueueManager.Instance.AddListener<MessageEvent>(AddEvent);
    }

    // 비활성화 시 더이상 자신이 관리되지않도록 삭제
    private void OnDisable()
    {
        EventQueueManager.Instance.RemoveListener<MessageEvent>(AddEvent);
    }

    // 활성화 시 우선순위에 따라 UI 업데이트
    private void OnEnable()
    {
        UpdateUI();
    }

    // 플로팅 시간 끝나면 관리되는 메시지에서 삭제
    private void Update()
    {
        for(int i = eventQueueList.Count - 1; i > -1; i--)
        {
            if(Time.time > eventQueueList[i].displayTime) eventQueueList.RemoveAt(i);
        }
    }

    // 메시지 우선순위에 따른 UI 업데이트
    private void UpdateUI()
    {
        LOW_PRIORITY.normal.textColor = lowPriorityColor;
        LOW_PRIORITY.fontStyle = lowPriorityFont;

        NORMAL_PRIORITY.normal.textColor = normalPriorityColor;
        NORMAL_PRIORITY.fontStyle = normalPriorityFont;

        HIGH_PRIORITY.normal.textColor = highPriorityColor;
        HIGH_PRIORITY.fontStyle = highPriorityFont;
    }

    // 화면에 메시지 출력
    private void OnGUI()
    {
        float yPos = messagePos.y;

        foreach(var m in eventQueueList)
        {
            GUIStyle style = GetMessageStyle(m);

            string message = preMessageTime ? m.timeRaised + " : " + m.message.ToString() : m.message.ToString();

            GUI.Label(new Rect(messagePos.x, yPos, messageSize.x, messageSize.y), message, style);

            yPos += messageSize.y;
        }
    }

    // 메시지 우선순위에 따른 스타일 반환
    private GUIStyle GetMessageStyle(IMessageEvent e)
    {
        switch(e.priority)
        {
            case MessagePriority.Low:
                return LOW_PRIORITY;
            case MessagePriority.Normal:
                return NORMAL_PRIORITY;
            default:
                return HIGH_PRIORITY;
        }
    }
}
