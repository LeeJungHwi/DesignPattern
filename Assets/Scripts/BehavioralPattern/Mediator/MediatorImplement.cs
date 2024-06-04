// 중재자 구현 : 당사자들 참조, 당사자가 Send 호출 시 중재자 Send를 거쳐 다른 당사자에게 메시지 전달
public class MediatorImplement : MediatorBase
{
    private PartyImplementA partyA;
    public PartyImplementA PartyA { set { partyA = value; } }
    private PartyImplementB partyB;
    public PartyImplementB PartyB { set { partyB = value; } }

    public override void Send(string message, PartyBase party)
    {
        if(party == partyA) partyB.Notify(message, party);
        else partyA.Notify(message, partyB);
    }
}
