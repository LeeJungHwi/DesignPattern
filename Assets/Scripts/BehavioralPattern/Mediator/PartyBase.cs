using UnityEngine;

// 당사자 베이스 : 중재자 참조, 메시지 전달 및 전달받은 메시지 알림
public abstract class PartyBase
{
    protected MediatorBase mediator;
    public PartyBase(MediatorBase mediator) { this.mediator = mediator; }
    public void Send(string message) { mediator.Send(message, this); }
    public void Notify(string message, PartyBase party) { Debug.Log(this.GetType().Name + "가 " + party.GetType().Name + "로 부터 " + message + " 를 받았습니다."); }
} 
