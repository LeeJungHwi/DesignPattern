// 중재자 베이스 : 당사자가 Send 호출 시 중재자 Send를 거쳐 다른 당사자에게 메시지 전달
public abstract class MediatorBase
{
    public abstract void Send(string message, PartyBase party);
}
