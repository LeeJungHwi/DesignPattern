using System;
using System.Collections.Generic;

// 메시지 우선순위
public enum MessagePriority { Low, Normal, High }

// 모든 이벤트 공통 멤버 정의
public abstract class GameEvent {}

// 메시지 이벤트 인터페이스
public interface IMessageEvent
{
    DateTime timeRaised { get; }
    float displayTime { get; }
    MessagePriority priority { get; }
    object message { get; }
}

// 메시지 이벤트 : 메시지 인터페이스를 구현하며, 메시지 내용을 가지고있음
public class MessageEvent : GameEvent, IMessageEvent
{
    public DateTime timeRaised { private set; get; }
    public float displayTime { private set; get; }
    public MessagePriority priority { private set; get; }
    public object message { private set; get; }

    public MessageEvent(object message, float displayTime, MessagePriority priority)
    {
        this.message = message;
        this.displayTime = displayTime;
        this.priority = priority;
        timeRaised = DateTime.Now;
    }
}

// 이벤트 큐 매니저 : 이벤트를 관리하며, 이벤트 타입과 해당 이벤트 타입을 처리할 델리게이트를 맵핑하고, 외부 이벤트를 내부 이벤트로 추가하거나 삭제하는 기능 제공
public class EventQueueManager
{
    // 싱글톤
    private static EventQueueManager instance;
    public static EventQueueManager Instance
    {
        get
        {
            if(instance == null) instance = new EventQueueManager();
            return instance;
        }
    }

    // 이벤트 관리
    public delegate void EventDelegate<T>(T e) where T : GameEvent;
    private delegate void EventDelegate(GameEvent e);

    // 이벤트 타입, 타입에 등록된 델리게이트 맵핑
    private Dictionary<System.Type, EventDelegate> typeMap = new Dictionary<System.Type, EventDelegate>();
    
    // 외부 델리게이트, 내부 델리게이트 맵핑
    private Dictionary<System.Delegate, EventDelegate> outerDelegateMap = new Dictionary<System.Delegate, EventDelegate>();

    // 이벤트 리스너 추가
    public void AddListener<T>(EventDelegate<T> del) where T : GameEvent
    {
        EventDelegate innerDelegate = (e) => { del((T)e); };

        if(outerDelegateMap.ContainsKey(del) && outerDelegateMap[del] == innerDelegate) return;

        outerDelegateMap[del] = innerDelegate;

        EventDelegate tempDel;
        if(typeMap.TryGetValue(typeof(T), out tempDel)) typeMap[typeof(T)] = tempDel += innerDelegate;
        else typeMap[typeof(T)] = innerDelegate;
    }

    // 이벤트 리스너 삭제
    public void RemoveListener<T>(EventDelegate<T> del) where T : GameEvent
    {
        EventDelegate innerDelegate;

        if(outerDelegateMap.TryGetValue(del, out innerDelegate))
        {
            EventDelegate tempDel;

            if(typeMap.TryGetValue(typeof(T), out tempDel))
            {
                tempDel -= innerDelegate;

                if(tempDel == null) typeMap.Remove(typeof(T));
                else typeMap[typeof(T)] = tempDel;
            }
        }

        outerDelegateMap.Remove(del);
    }

    // 이벤트 추가
    public void AddEvent(GameEvent e)
    {
        EventDelegate del;

        if(typeMap.TryGetValue(e.GetType(), out del)) del.Invoke(e);
    }
}
